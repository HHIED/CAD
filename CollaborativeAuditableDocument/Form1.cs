using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CollaborativeAuditableDocument.FirestoreEntities;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace CollaborativeAuditableDocument
{
    public partial class Form1 : Form
    {
        private FirestoreChangeListener listener;
        public Form1()
        {
            InitializeComponent();
            
            listener = Firestore.Instance.ListenToSections(UpdateList);
        }

        private void UpdateList(List<Section> sections)
        {   
            sectionListbox.DataSource = sections.Where(x=>x.ApprovedAt==null).ToList();
            List<Section> documentSections = sections.Where(x => x.ApprovedAt != null).ToList();
            documentListbox.DataSource = documentSections;
            finalDocBox.Clear();
            this.Invoke((MethodInvoker)delegate { UpdateDocument(documentSections); });
        }



        private void UpdateDocument(List<Section> sections)
        {
            foreach (Section s in sections)
            {
                finalDocBox.AppendText(s.Title + "\n" + s.Text + "\n\n");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            List<HistoryItem> history = new List<HistoryItem>();
            HistoryItem h = new HistoryItem
            {
                Action = ActionType.CREATED,
                ActionBy = Core.Instance.User
            };
            string[] approvedBy = {Core.Instance.User};
            Section section = new Section
            {
                Title = titleTxt.Text,
                Text = ContentBox.Text,
                Order = int.Parse(sectionNumberTxt.Text),
                History = history,
                ApprovedBy = approvedBy
                
                
            };
            Core.Instance.AddSection(section);
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Section section = (Section) sectionListbox.SelectedItem;
            Core.Instance.ApproveSection(section, Core.Instance.User);
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            Section section = (Section)sectionListbox.SelectedItem;
            Core.Instance.DeclineSection(section, Core.Instance.User);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Firestore.Instance.StopListener(listener);
        }
    }
}
