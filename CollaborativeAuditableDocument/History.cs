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
    public partial class History : Form
    {
        public History(SectionUI s)
        {
            InitializeComponent();
            foreach (HistoryItem h in s.History)
            {
                HistoryTextBox.Text = h.ToString();
            }
            
        }
    }
}
