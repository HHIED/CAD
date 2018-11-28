using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace CollaborativeAuditableDocument.FirestoreEntities {
    [FirestoreData]
    public class Section {
        [FirestoreProperty]
        public string Title { get; set; }
        [FirestoreProperty]
        public string Text { get; set; }
        [FirestoreProperty]
        public int Order { get; set; }
        [FirestoreProperty]
        public string CreatedBy { get; set; }
        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
        [FirestoreProperty]
        public string[] ApprovedBy { get; set; }
        [FirestoreProperty]
        public DateTime ApprovedAt { get; set; }
    }
}
