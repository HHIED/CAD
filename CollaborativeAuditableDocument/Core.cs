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

        public async void Login(string user) {
            bool isAuth = await Firestore.Instance.CheckUsername(user);
            Login(isAuth);
            User = user;
        }

        private void Login(bool isAuth)
        {
            if (isAuth)
            {
                Form1 main = new Form1();
                main.Show();
            }
        }

        internal async void AddSection(Section section)
        {
            await Firestore.Instance.AddNewSection(section);
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
