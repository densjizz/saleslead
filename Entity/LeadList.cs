using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LeadLibrary
    {

        private List<Lead> _leads { get; set; }

        public LeadLibrary() {
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

        public void Delete(Guid uid)
        {
            for (int i = 0; i < _leads.Count; i++) {
                if (_leads[i].UID == uid) {
                    _leads.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
