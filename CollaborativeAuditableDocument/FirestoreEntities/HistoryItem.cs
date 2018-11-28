using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace CollaborativeAuditableDocument.FirestoreEntities {
    [FirestoreData]
    public class HistoryItem {
        [FirestoreProperty]
        public int Action { get; set; }
        [FirestoreProperty]
        public string ActionBy { get; set; }
        [FirestoreProperty]
        public DateTime ActionAt { get; set; }
    }
}
