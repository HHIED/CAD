using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollaborativeAuditableDocument.FirestoreEntities;

namespace CollaborativeAuditableDocument {
    public sealed class Core {
        public string User {get; set; }
        private static Core instance = null;
        public Form1 main { get; set; }

        private Core() {
        }

        public static Core Instance {
            get {
                if (instance == null) {
                    instance = new Core();
                }
                return instance;
            }
        }

        public List<Section> GetSections()
        {
            return Firestore.Instance.GetSections().Result;
        }

        public bool Login(string user) {
            bool test = Firestore.Instance.CheckUsername(user).Result;
            Console.WriteLine(test);
            return test;
        }

        internal void AddSection(Section section)
        {
            throw new NotImplementedException();
        }

        internal void ApproveSection(Section section, string user)
        {
            
            bool isApproved = Firestore.Instance.ApproveSection(user, section.Id).Result;
        }

        internal void DeclineSection(Section section, string user)
        {
            throw new NotImplementedException();
        }

        internal void EditSection(Section section)
        {
            throw new NotImplementedException();
        }
    }
}
