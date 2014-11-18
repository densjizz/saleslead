using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interactor;
using Entity.Activity;

namespace Saleslead_InteractorTest
{
    [TestClass]
    public class ActionInterfactionsTest
    {
        [TestMethod]
        public void CreateAction()
        {
            //Arrange
            LeadActionInteractions leadManager = new LeadActionInteractions();

            //Act
            LeadAction act = leadManager.CreateLeadAction();

            //Assert
            Assert.AreNotEqual(act.UID, Guid.Empty);
        }
    }
}
