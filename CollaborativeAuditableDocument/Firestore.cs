using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Google.Cloud.Firestore;
using CollaborativeAuditableDocument.FirestoreEntities;

namespace CollaborativeAuditableDocument
{
    public class Firestore {
        public static Firestore instance;
        
        public static Firestore GetFirestore() {
            if (instance == null) {
                instance = new Firestore();
            }
            return instance;
        }

        public FirestoreDb db;

        public Firestore() {
            db = FirestoreDb.Create("sdu-isl-cad");
        }

        public async Task<List<Section>> GetSections() {
            CollectionReference docRef = db.Collection("sections");
            QuerySnapshot qs = await docRef.GetSnapshotAsync();
            return ConvertToList(qs);
        }

        public FirestoreChangeListener ListenToSections(Action<List<Section>> callback) {
            CollectionReference colRef = db.Collection("sections");
            return colRef.Listen(snapshot => {
                callback(ConvertToList(snapshot));
            });
        }

        public async Task StopListener(FirestoreChangeListener listener) {
            await listener.StopAsync();
        }

        private List<Section> ConvertToList(QuerySnapshot snapshot) {
            List<Section> sections = new List<Section>();
            foreach (DocumentSnapshot ds in snapshot.Documents) {
                if (ds.Exists) {
                    Section s = ds.ConvertTo<Section>();
                    s.Id = ds.Id;
                    sections.Add(s);
                }
            }
            return sections;
        }

        public async Task<string> SaveSection(Section section) {
            DocumentReference docRef = await db.Collection("sections").AddAsync(section);
            return docRef.Id;
        }

        public async Task<string> AddNewSection(string username, string title, string text, int order) {
            CollectionReference colRef = db.Collection("sections");
            string[] approvedBy = { username };
            HistoryItem createdItem = new HistoryItem {
                Action = ActionType.CREATED,
                ActionBy = username,
                ActionAt = DateTime.Now
            };
            List<HistoryItem> history = new List<HistoryItem>();
            history.Add(createdItem);
            Section section = new Section {
                Title = title,
                Text = text,
                Order = order,
                History = history,
                ApprovedBy = approvedBy
            };
            DocumentReference docRef = await colRef.AddAsync(section);
            return docRef.Id;
        }

        /// <summary>
        /// Approves a section. Returns true if the section has been approved by everyone.
        /// </summary>
        /// <param name="username">Username approving</param>
        /// <param name="sectionId">Section to approve</param>
        /// <returns>Whether section has been approved by all or not</returns>
        public async Task<Boolean> ApproveSection(string username, string sectionId) {
            DocumentReference docRef = db.Collection("sections").Document(sectionId);
            CollectionReference userRef = db.Collection("users");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if(snapshot.Exists) {
                Section section = snapshot.ConvertTo<Section>();
                if(!section.ApprovedBy.Contains(username)) {
                    await docRef.UpdateAsync("ApprovedBy", FieldValue.ArrayUnion(username));
                }
                QuerySnapshot userSnapshots = await userRef.GetSnapshotAsync();
                if(userSnapshots.Count <= section.ApprovedBy.Count()) {
                    await docRef.UpdateAsync("ApprovedAt", DateTime.Now);
                    return true;
                }
            }
            return false;
        }
    }
}
