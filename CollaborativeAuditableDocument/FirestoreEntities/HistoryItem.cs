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
        public Timestamp ActionAt { get; set; }

        public string ToString()
        {
            return "Action: " + Action + " Action By: " + ActionBy + " Action time: " + ActionAt.ToString() + "\n";
        }
    }
}
