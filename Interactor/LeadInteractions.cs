using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Saleslead_Contract;
using Saleslead_Contract.Lead;




namespace Interactor
{
    public class LeadInteractions
    {


        private LeadLibrary _leads;

        public LeadInteractions() {
            _leads = new LeadLibrary();
        }

        public LeadLibraryResponse GetLeads()
        {
            List<Lead> leads = _leads.GetAllLeads();
            return ConvertToLeadLibraryResponse(leads);
        }

        private LeadLibraryResponse ConvertToLeadLibraryResponse(List<Lead> leads)
        {
            LeadLibraryResponse response = new LeadLibraryResponse();
            foreach (Lead lead in leads)
            {
                response.leads.Add(ConvertToLeadResponse(lead));
            }
            return response;
        }

        private LeadResponse ConvertToLeadResponse(Lead e)
        {
            LeadResponse leadResponse = new LeadResponse();
            leadResponse.Amount = e.Amount;
            leadResponse.CreatedBy = e.CreatedStamp.By;
            leadResponse.CreatedDate = e.CreatedStamp.Date;
            leadResponse.ModifiedBy = e.ModifiedStamp.By;
            leadResponse.ModifiedDate = e.ModifiedStamp.Date;
            leadResponse.Title = e.Title;
            leadResponse.UID = e.UID;
            return leadResponse;
        }


        public LeadResponse GetLead(LeadRequest request)
        {

            Lead lead = _leads.GetLead(request.UID);
            return ConvertToLeadResponse(lead);
        }

        public LeadResponse CreateLead(CreateLeadRequest createLeadRequest)
        {
            Lead lead = ConvertToLead(createLeadRequest);
            _leads.AddLead(lead);
            return ConvertToLeadResponse(lead);
        }

        private static Lead ConvertToLead(CreateLeadRequest createLeadRequest)
        {
            Lead lead = new Lead();
            lead.UID = createLeadRequest.UID;
            lead.Title = createLeadRequest.Title;
            lead.CreatedStamp.By = createLeadRequest.CreatedBy;
            lead.CreatedStamp.Date = createLeadRequest.CreatedDate;
            lead.Amount = createLeadRequest.Amount;
            return lead;
        }
    }
}
