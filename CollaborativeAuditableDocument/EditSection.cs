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
            InitializeComponent();
            titleTxt.Text = section.Title;
            ContentBox.Text = section.Text;
            sectionNumberTxt.Text = section.Order.ToString();
            this.section = section;
        }

        private void editComplete_Click(object sender, EventArgs e)
        {
            List<HistoryItem> history = section.History;
            HistoryItem h = new HistoryItem
            {
                Action = 0,
                ActionAt = DateTime.Now,
                ActionBy = Core.Instance.User
            };
            history.Add(h);
            section.History = history;
            
            Core.Instance.EditSection(section);
        }
    }
}
