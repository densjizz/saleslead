using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Status;
using Entity.Interfaces;
using Entity.Notes;
using Entity.Collaboration;
using Entity.Business;
using Entity.Activity;
using Entity.Modifications;

namespace Entity
{
    public class Lead
    {
        public Guid UID { get; set; }
        public string Title { get; set; }
        public Status.Status Status { get; set; }
        public Rating.Rating Rating { get; set; }
        public float Amount { get; set; }
        public List<Note> Notes { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Contributer> Contributers { get; set; }
        public List<LeadAction> Actions { get; set; }

        public ChangeStamp ModifiedStamp { get; set; }
        public ChangeStamp CreatedStamp { get; set; }

        

        public Lead() {
            UID = Guid.NewGuid();
            
            Rating = new Rating.LeadRating();
            Status = new Status.LeadStatus();
            Notes = new List<Note>();
            Contacts = new List<Contact>();
            Contributers = new List<Contributer>();
            Actions = new List<LeadAction>();
            ModifiedStamp = new ChangeStamp();
            CreatedStamp = new ChangeStamp();
            CreatedStamp.Date = DateTime.Now;
            CreatedStamp.By = "System";
        }


        public void ModifyNow(string ModifiedBy)
        {
            ModifiedStamp.By = ModifiedBy;
            ModifiedStamp.Date = DateTime.Now;
        }

        public void CreatedNow(string CreatedBy) {
            CreatedStamp.By = CreatedBy;
            CreatedStamp.Date = DateTime.Now;
        }
    }
}
