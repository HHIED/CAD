using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollaborativeAuditableDocument.FirestoreEntities;

namespace CollaborativeAuditableDocument
{
    public partial class EditSection : Form
    {
        private Section oldSection;

        public EditSection(Section section)
        {
            InitializeComponent();
            titleTxt.Text = section.Title;
            ContentBox.Text = section.Text;
            sectionNumberTxt.Text = section.Order.ToString();
            oldSection = section;
        }

        private void editComplete_Click(object sender, EventArgs e)
        {
            Section section = new Section
            {
                Title = titleTxt.Text,
                Text = ContentBox.Text,
                Order = int.Parse(sectionNumberTxt.Text),
                CreatedAt = DateTime.Now,
                CreatedBy = Core.Instance.User

            };
            Core.Instance.EditSection(oldSection, section);
        }
    }
}
