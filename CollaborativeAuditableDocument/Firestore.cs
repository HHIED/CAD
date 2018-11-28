using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

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
    }
}
