using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Google.Cloud.Firestore;

namespace CollaborativeAuditableDocument.FirestoreEntities {
    [FirestoreData]
    public class Section {
        public string Id { get; set; }
        [FirestoreProperty]
        public string Title { get; set; }
        [FirestoreProperty]
        public string Text { get; set; }
        [FirestoreProperty]
        public int Order { get; set; }
        [FirestoreProperty]
        public List<HistoryItem> History { get; set; }
        [FirestoreProperty]
        public string[] ApprovedBy { get; set; }
        [FirestoreProperty]
        public Timestamp? ApprovedAt { get; set; }
    }
}
