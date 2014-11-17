using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using Interactor;
using Entity.Activity;
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
            
            //l.Title
            string LeadTitle = "New lead title";
            //l.Status
            //l.Rating
            //l.Notes
            //l.CurrentAction
            //l.Contributers
            //l.Contacts
            //l.Amount
            //l.Actions
               
            //Act
            Guid LeadGuid = leadInteractions.AddLead(LeadTitle);
            Lead newlyCreatedLead = leadInteractions.GetLead(LeadGuid);


            //Assert
            Assert.IsTrue(newlyCreatedLead.UID == LeadGuid);
            Assert.IsTrue( (DateTime.Now - newlyCreatedLead.CreateDate) < new TimeSpan(0,0,5));
            Assert.IsTrue(newlyCreatedLead.UID != Guid.Empty);
            Assert.IsTrue(newlyCreatedLead.CreateBy != null);
            Assert.IsTrue(newlyCreatedLead.ModifiedBy != null);
            Assert.IsTrue(newlyCreatedLead.CreateBy != null);
            Assert.IsTrue(newlyCreatedLead.CreateBy != null);
        }

        [TestMethod]
        public void GetLeads()
        {
            //Arrange
            LeadInteractions leadInteractions = new LeadInteractions();
            LeadActionInteractions leadActionInteractions = new LeadActionInteractions();


            Lead newLead = null;

            //Act
            int index = 0;
            int NumberOfLeads = 0;
            List<Lead> leadList = leadInteractions.GetLeads(index, NumberOfLeads);


            //assert
            Assert.IsTrue(leadList.Count == NumberOfLeads);
        }


        [TestMethod]
        public void DeleteLead()
        {
        }

        


    }
}
