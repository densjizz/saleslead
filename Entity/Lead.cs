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

namespace Entity
{
    public class Lead : IModifiable, ICreatable
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

        public string ModifiedBy {get; set;}
        public DateTime ModifiedDate { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }


        public Lead() {
            UID = Guid.NewGuid();
            CreateDate = DateTime.Now;
            Rating = new Rating.LeadRating();
            Status = new Status.LeadStatus();
            Notes = new List<Note>();
            Contacts = new List<Contact>();
            Contributers = new List<Contributer>();
            Actions = new List<LeadAction>();
        }

    }
}
