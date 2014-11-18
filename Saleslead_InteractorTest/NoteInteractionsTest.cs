using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interactor;
using Entity.Notes;

namespace Saleslead_InteractorTest
{
    [TestClass]
    public class NoteInteractionsTest
    {






        [TestMethod]
        public void CreateNote()
        {

            //Arrange
            NoteInteractions noteInter = new NoteInteractions();
            Note n;
            string title = "Notes For TDD";
            string noteText = "This is a very long note text";
            string user = "Mathieu";
            DateTime creationDate;

            //Act
            creationDate = DateTime.Now;
            n = noteInter.Create(user, title, noteText);

            //Assert
            Assert.IsTrue(n.Message == noteText);
            Assert.IsTrue(n.CreationStamp.By == user);
            Assert.IsTrue(n.CreationStamp.Date - creationDate < new TimeSpan(0, 5, 0));
        }



        [TestMethod]
        public void GetNotes()
        {

        }

        [TestMethod]
        public void UpdateNotes()
        {

        }


        [TestMethod]
        public void DeleteNote()
        {

        }


    }
}
