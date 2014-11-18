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

        
      

    }
}
