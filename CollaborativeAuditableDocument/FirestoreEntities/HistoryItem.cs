using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeAuditableDocument.FirestoreEntities {
    public enum ActionType {
        CREATED, UPDATED, DELETED
    }

    public class HistoryItem {
        public ActionType Action { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionAt { get; set; }
    }
}
