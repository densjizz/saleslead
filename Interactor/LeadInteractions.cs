using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interactor
{
    public class LeadInteractions
    {


        private LeadList _leads;

        public LeadInteractions() {
            _leads = new LeadList();
        }

        

        public Lead GetLead(Guid requestedLeadUID)
        {
            return _leads.GetLead(requestedLeadUID);
        }

        public List<Lead> GetLeads(int index, int NumberOfLeads)
        {
            
            List<Lead> leadList = new List<Lead>();

            

            for (int i = index; i < NumberOfLeads; i++) {
                Lead lead = _leads.GetLead(i);
                leadList.Add(lead);
            }


            return leadList;
        }

        public void AddLead(Lead newLead)
        {
            _leads.AddLead(newLead);
        }

        public List<Lead> GetLeads()
        {
            return _leads.GetAllLeads();
        }

        public Guid AddLead(string LeadTitle)
        {
            Lead newLead = new Lead();
            newLead.Title = LeadTitle;
            _leads.AddLead(newLead);
            return newLead.UID;
        }

        public void AddActionToLead(Entity.Activity.LeadAction action, Lead newLead)
        {
            newLead.Actions.Add(action);
        }

        public void DeleteLead(Guid uid)
        {
            _leads.Delete(uid);
        }

        public Lead GetLead(int index)
        {
            return _leads.GetLead(index);
        }
    }
}
