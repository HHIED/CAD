using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace CollaborativeAuditableDocument.FirestoreEntities
{
    public class SectionUI
    {
        public string Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public List<HistoryItem> History { get; set; }
        public List<string> ApprovedBy { get; set; }
        public int Approves { get; set; }
        public Timestamp? ApprovedAt { get; set; }

        public SectionUI(Section s)
        {
            Id = s.Id;
            Title = s.Title;
            Text = s.Text;
            Order = s.Order;
            History = s.History;
            Approves = s.ApprovedBy.Count;
            ApprovedAt = s.ApprovedAt;
            ApprovedBy = s.ApprovedBy;
            
        }

        public Section ToSection()
        {
            Section s = new Section
            {
                ApprovedBy = this.ApprovedBy,
                History = this.History,
                ApprovedAt = this.ApprovedAt,
                Id = this.Id,
                Order = this.Order,
                Text = this.Text,
                Title = this.Title
            
                
            };
            return s;
        }
    }
}
