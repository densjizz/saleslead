using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interactor;
using System.Collections.Generic;
using Saleslead_Contract.Lead;

namespace Saleslead_InteractorTest
{
    [TestClass]
    public class LeadInteractionsTest
    {

        [TestMethod]
        public void GetAllLeads()
        {
            //arrange
            LeadInteractions leadInteractions = new LeadInteractions();
            //act
            var list = leadInteractions.GetLeads();
            //assert
            Assert.IsTrue(list.leads.Count > 0);
        }


        [TestMethod]
        public void GetLeadByUID()
        {
            //arrange
            LeadInteractions leadInteractions = new LeadInteractions();
            LeadRequest request = new LeadRequest();
            var allLeads = leadInteractions.GetLeads();
            request.UID = allLeads.leads[0].UID;


            //act
            var lead = leadInteractions.GetLead(request);
            //assert
            Assert.IsTrue(lead != null);
            Assert.IsTrue(lead.UID == request.UID);
        }

        [TestMethod]
        public void CreateLead() {
            //Arrange
            LeadInteractions leadInteractions = new LeadInteractions();
            CreateLeadRequest createLeadRequest = new CreateLeadRequest();

            //Act
            var response = leadInteractions.CreateLead(createLeadRequest);
            
            //assert
            Assert.IsTrue(response != null);
            Assert.IsTrue(response.UID == createLeadRequest.UID);
            Assert.IsTrue(response.Title == createLeadRequest.Title);
            Assert.IsTrue(response.Amount == createLeadRequest.Amount);
            Assert.IsTrue(response.CreatedBy == createLeadRequest.CreatedBy);
            Assert.IsTrue(response.CreatedDate == createLeadRequest.CreatedDate);
            Assert.IsTrue(response.IsValid);
            
        }

        [TestMethod]
        public void UpdateLead() {
            //Arrange
            LeadInteractions leadInteractions = new LeadInteractions();
            UpdateLeadRequest UpdateLeadRequest = new UpdateLeadRequest();
            var allLeads = leadInteractions.GetLeads();
            UpdateLeadRequest.UID = allLeads.leads[0].UID;

            //Act
            var response = leadInteractions.UpdateLead(UpdateLeadRequest);

            //assert
            Assert.IsTrue(response != null);
            Assert.IsTrue(response.UID == UpdateLeadRequest.UID);
            Assert.IsTrue(response.Title == UpdateLeadRequest.Title);
            Assert.IsTrue(response.Amount == UpdateLeadRequest.Amount);
            Assert.IsTrue(response.ModifiedBy == UpdateLeadRequest.ModifiedBy);
            Assert.IsTrue(response.ModifiedDate == UpdateLeadRequest.ModifiedDate);
            Assert.IsTrue(response.IsValid);
        }


        [TestMethod]
        public void Delete() { 
            
        }

    }
}
