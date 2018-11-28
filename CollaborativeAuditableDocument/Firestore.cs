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
        private static Firestore instance;

        public static Firestore Instance {
            get {
                if (instance == null) {
                    instance = new Firestore();
                }
                return instance;
            }
        }

        private FirestoreDb db;

        public Firestore() {
            db = FirestoreDb.Create("sdu-isl-cad");
        }

        public async Task<List<Section>> GetSections() {
            Query docRef = db.Collection("sections").OrderBy("Order");
            QuerySnapshot qs = await docRef.GetSnapshotAsync();
            return ConvertToList(qs);
        }

        public FirestoreChangeListener ListenToSections(Action<List<Section>> callback) {
            Query colRef = db.Collection("sections").OrderBy("Order");
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

        public async Task<string> AddNewSection(string username, Section section) {
            Query heigherOrder = db.Collection("sections").WhereGreaterThanOrEqualTo("Order", section.Order);
            QuerySnapshot querySnapshot = await heigherOrder.GetSnapshotAsync();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();
            foreach(DocumentSnapshot doc in querySnapshot.Documents) {
                Section s = doc.ConvertTo<Section>();
                newOrders.Add(doc.Id, doc.GetValue<int>("Order"));
            }

            WriteBatch batch = db.StartBatch();

            foreach(KeyValuePair<string, int> entry in newOrders) {

            }

            await batch.CommitAsync();

            DocumentReference docRef = await db.Collection("sections").AddAsync(section);
            return docRef.Id;
        }

        public async Task UpdateSection(string username, Section section) {
            DocumentReference docRef = db.Collection("section").Document(section.Id);
            string[] approvedBy = new string[] { username };
            Dictionary<string, object> updates = new Dictionary<string, object> {
                { "Title", section.Title },
                { "Text", section.Text },
                { "ApprovedBy", approvedBy },
                { "ApprovedAt", null }
            };
            await docRef.UpdateAsync(updates);
            await docRef.UpdateAsync("History", FieldValue.ArrayUnion(new HistoryItem {
                Action = 1,
                ActionBy = username,
                ActionAt = DateTime.Now
            }));
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

        public async Task<Boolean> CheckUsername(string username) {
            Console.WriteLine("Checking username: " + username);
            DocumentReference docRef = db.Collection("users").Document(username);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if(snapshot.Exists) {
                Console.WriteLine("User found");
                return true;
            }
            Console.WriteLine("User not found");
            return false;
        }
    }
}
