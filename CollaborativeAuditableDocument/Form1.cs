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
            List<Section> UnapprovedSection = sections.Where(x => x.ApprovedAt == null).ToList();
            List<Section> documentSections = sections.Where(x => x.ApprovedAt != null).ToList();
            
            this.Invoke((MethodInvoker)delegate { updateSectionGrids(ListFromSections(UnapprovedSection), ListFromSections(documentSections)); });
            this.Invoke((MethodInvoker)delegate { UpdateDocument(ListFromSections(documentSections)); });
        }

        private void updateSectionGrids(List<SectionUI> sections, List<SectionUI> documentSections)
        {
            DateTime comparer = new DateTime(0, DateTimeKind.Utc);
            sectionGrid.DataSource = sections;
            documentSectionGrid.DataSource = documentSections;
        }

        private List<SectionUI> ListFromSections(List<Section> sections)
        {
            List<SectionUI> sectionUIs = new List<SectionUI>();
            foreach(Section s in sections)
            {
                sectionUIs.Add(s.ToSectionUI());
            }
            return sectionUIs;
        }



        private void UpdateDocument(List<SectionUI> sections)
        {
            finalDocBox.Clear();
            foreach (SectionUI s in sections)
            {
                finalDocBox.AppendText(s.Title + "\n" + s.Text + "\n\n");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            List<string> approvedBy = new List<string>();
            approvedBy.Add(Core.Instance.User);
            Section section = new Section
            {
                Title = titleTxt.Text,
                Text = ContentBox.Text,
                Order = int.Parse(sectionNumberTxt.Text),
                ApprovedBy = approvedBy
                
                
            };
            Core.Instance.AddSection(section);
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            SectionUI section = (SectionUI) sectionGrid.CurrentRow.DataBoundItem;

            Core.Instance.ApproveSection(section.ToSection(), Core.Instance.User);
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            SectionUI section = (SectionUI)sectionGrid.CurrentRow.DataBoundItem;
            Core.Instance.DeclineSection(section.ToSection(), Core.Instance.User);
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Firestore.Instance.StopListener(listener);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            SectionUI s = (SectionUI)documentSectionGrid.CurrentRow.DataBoundItem;
            EditSection edit = new EditSection(s.ToSection());
            edit.Show();
        }
    }
}
