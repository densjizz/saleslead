using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LeadList
    {

        private List<Lead> _leads { get; set; }

        public LeadList() {
            LoadLeads();
        }

        public void LoadLeads() {
            _leads = new List<Lead>();
            Random rdm = new Random();
            for (int i = 0; i < 300; i++) {
                Lead newLead = new Lead();
                newLead.Title = "Lead Item " + i;
                newLead.Status = new Status.Status();
                newLead.Rating = new Rating.Rating();
                newLead.CreateBy = "System";
                newLead.CreateDate = DateTime.Now;
                _leads.Add(newLead);
            }
        }

        public Lead GetLead(int index)
        {
            return _leads[index];
        }

        public Lead GetLead(Guid requestedLeadUID)
        {
            foreach (Lead l in _leads) {
                if (l.UID == requestedLeadUID) {
                    return l;
                }
            }

            return null;
        }

        public void AddLead(Lead newLead)
        {
            _leads.Add(newLead);
        }

        public List<Lead> GetAllLeads()
        {
            List<Lead> result = new List<Lead>(_leads);            
            return result;
        }
    }
}
