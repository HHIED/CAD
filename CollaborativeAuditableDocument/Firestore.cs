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
            db = FirestoreDb.Create();
        }

        public async Task<Section[]> GetSections() {
            CollectionReference docRef = db.Collection("sections");
            QuerySnapshot qs = await docRef.GetSnapshotAsync();
            List<Section> sections = new List<Section>();
            foreach(DocumentSnapshot ds in qs.Documents) {
                if (ds.Exists) {
                    Section s = ds.ConvertTo<Section>();
                    sections.Add(s);
                }
            }
            return sections.ToArray();
        }

        public async Task<string> SaveSection(Section section) {
            DocumentReference docRef = await db.Collection("sections").AddAsync(section);
            return docRef.Id;
        }

        public async Task<string> addNewSection(string username, string title, string text, int order) {
            CollectionReference colRef = db.Collection("sections");
            string[] approvedBy = { username };
            Section section = new Section {
                Title = title,
                Text = text,
                Order = order,
                CreatedAt = DateTime.Now,
                CreatedBy = username,
                ApprovedBy = approvedBy
            };
            DocumentReference docRef = await colRef.AddAsync(section);
            return docRef.Id;
        }

        public async Task approveSection(string username, string sectionId) {
            DocumentReference docRef = db.Collection("sections").Document(sectionId);

        }
    }
}
