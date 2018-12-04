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
        private Section section;

        public EditSection(Section section)
        {
            this.section = section;
            InitializeComponent();
            titleTxt.Text = section.Title;
            ContentBox.Text = section.Text;
            
        }

        private void editComplete_Click(object sender, EventArgs e)
        {
            section.Text = ContentBox.Text;
            section.Title = titleTxt.Text;
            Core.Instance.EditSection(section);
            this.Close();
        }
    }
}
