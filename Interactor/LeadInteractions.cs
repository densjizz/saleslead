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

        public LeadResponse UpdateLead(UpdateLeadRequest UpdateLeadRequest)
        {
            Lead concernedLead = GetLeadFromUpdateRequest(UpdateLeadRequest);
            UpdateLeadFromRequest(UpdateLeadRequest, concernedLead);
            return ConvertToLeadResponse(concernedLead);

        }

        #region privates
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
            leadResponse.Title = e.Title;
            leadResponse.UID = e.UID;
            leadResponse.IsValid = true;
            leadResponse.SetCreateInfo(e.CreatedStamp.By, e.CreatedStamp.Date);
            leadResponse.SetModificationInfo(e.ModifiedStamp.By, e.ModifiedStamp.Date);

            return leadResponse;
        }

        

        private static Lead ConvertToLead(CreateLeadRequest createLeadRequest)
        {
            Lead lead = new Lead();
            lead.UID = createLeadRequest.UID;
            lead.Title = createLeadRequest.Title;
            lead.CreatedStamp.Update(createLeadRequest.CreatedBy, createLeadRequest.CreatedDate);
            lead.Amount = createLeadRequest.Amount;
            return lead;
        }
        #endregion

        private static void UpdateLeadFromRequest(UpdateLeadRequest UpdateLeadRequest, Lead concernedLead)
        {
            if (concernedLead != null)
            {
                concernedLead.Title = UpdateLeadRequest.Title;
                concernedLead.ModifiedStamp.By = UpdateLeadRequest.ModifiedBy;
                concernedLead.ModifiedStamp.Date = UpdateLeadRequest.ModifiedDate;
                concernedLead.Amount = UpdateLeadRequest.Amount;
            }
        }

        private Lead GetLeadFromUpdateRequest(UpdateLeadRequest UpdateLeadRequest)
        {
            Lead result = GetLeadByUpdateRequestUID(UpdateLeadRequest);
            return result;
        }

        private Lead GetLeadByUpdateRequestUID(UpdateLeadRequest UpdateLeadRequest)
        {
            if (IsUpdateRequestByUID(UpdateLeadRequest))
            {
                return _leads.GetLead(UpdateLeadRequest.UID);
            }
            return null;
        }

        private bool IsUpdateRequestByUID(UpdateLeadRequest UpdateLeadRequest)
        {
            return UpdateLeadRequest.UID != null && UpdateLeadRequest.UID != Guid.Empty;
        }
    }
}
