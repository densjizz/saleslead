using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using Interactor;
using Entity.Activity;
using Entity.Modifications;
using System.Collections.Generic;

namespace Saleslead_InteractorTest
{
    [TestClass]
    public class LeadInteractionsTest
    {

        [TestMethod]
        public void GetAllLeads() { 
            

            //arrange
            LeadInteractions leadInteractions = new LeadInteractions();


            //act
            List<Lead> list = leadInteractions.GetLeads();

            //assert
            Assert.IsTrue(list.Count > 0);

        }

        [TestMethod]
        public void CreateAddNewLead()
        {
            //Arrange
            LeadInteractions leadInteractions = new LeadInteractions();
            LeadActionInteractions leadActionInteractions = new LeadActionInteractions();

            Lead l = null;
            string LeadTitle = "New lead title";
               
            //Act
            Guid LeadGuid = leadInteractions.AddLead(LeadTitle);
            Lead newlyCreatedLead = leadInteractions.GetLead(LeadGuid);

            //Assert
            Assert.IsTrue(newlyCreatedLead.UID == LeadGuid);
            Assert.IsTrue(newlyCreatedLead.UID != Guid.Empty);
            Assert.IsTrue((DateTime.Now - newlyCreatedLead.CreatedStamp.Date) < new TimeSpan(0, 5, 0));

            Assert.IsTrue(newlyCreatedLead.ModifiedStamp != null);
            Assert.IsTrue(newlyCreatedLead.ModifiedStamp.By != null);

            Assert.IsTrue(newlyCreatedLead.CreatedStamp != null);
            Assert.IsTrue(newlyCreatedLead.CreatedStamp.By != null);
            Assert.IsTrue(newlyCreatedLead.CreatedStamp.Date != DateTime.MinValue);

            Assert.IsTrue(newlyCreatedLead.Status != null);
            Assert.IsTrue(!string.IsNullOrEmpty(newlyCreatedLead.Status.Text));
            Assert.IsTrue(newlyCreatedLead.Status.UID != null && newlyCreatedLead.Status.UID != Guid.Empty);

            Assert.IsTrue(newlyCreatedLead.Rating != null);
            Assert.IsTrue(!string.IsNullOrEmpty(newlyCreatedLead.Rating.Text));
            Assert.IsTrue(newlyCreatedLead.Rating.UID != null && newlyCreatedLead.Rating.UID != Guid.Empty);
            
        }

        [TestMethod]
        public void GetLeads()
        {
            //Arrange
            LeadInteractions leadInteractions = new LeadInteractions();


            Lead newLead = null;

            //Act
            int index = 0;
            int NumberOfLeads = 5;
            List<Lead> leadList = leadInteractions.GetLeads(index, NumberOfLeads);


            //assert
            Assert.IsTrue(leadList.Count == NumberOfLeads);
        }


        [TestMethod]
        public void DeleteLead()
        {
            //Arrange
            LeadInteractions leadInteractions = new LeadInteractions();

            Random r = new Random();
            int rdmNumber = r.Next() * 10000;
            string NewLeadTitle = "NewLeadTest" + rdmNumber;
            Guid newLeadUID = leadInteractions.AddLead(NewLeadTitle);
            int totalNumberOfLeads = leadInteractions.GetLeads().Count;

            //Act
            leadInteractions.DeleteLead(newLeadUID);
            int newTotalNumberOfLeads = leadInteractions.GetLeads().Count;
            int delta = totalNumberOfLeads - newTotalNumberOfLeads;

            //Assert
            Assert.IsTrue(delta == 1);
        }

        public void ModifyLead() {
            //Arrange
            int index = 0;
            LeadInteractions leadInteractions = new LeadInteractions();
            Lead lead = leadInteractions.GetLead(index);
            string username = "TDD";

            //Act
            DateTime now = DateTime.Now;
            lead.ModifyNow(username);

            //Assert
            Assert.IsTrue(now - lead.ModifiedStamp.Date < new TimeSpan(0, 5, 0));
            Assert.IsTrue(lead.ModifiedStamp.By == username);
        }

        


    }
}
