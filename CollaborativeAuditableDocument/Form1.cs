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

namespace CollaborativeAuditableDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Section section = new Section
            {
                Title = titleTxt.Text,
                Text = ContentBox.Text,
                Order = int.Parse(sectionNumberTxt.Text),
                CreatedAt = DateTime.Now,
                CreatedBy = Core.Instance.User
                
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
    }
}
