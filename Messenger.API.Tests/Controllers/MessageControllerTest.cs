using Messenger.API.Controllers;
using Messenger.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messenger.Data.Model;

namespace Messenger.API.Tests.Controllers
{
    /// <summary>
    /// Descripción resumida de MessageControllerTest
    /// </summary>
    [TestClass]
    public class MessageControllerTest
    {
       
        [TestMethod]
        public void Get()
        {
            // Disponer
            MessageController controller = new MessageController();

            // Actuar
            List<Messages> result = controller.Get();

            // Declarar
            Assert.IsNotNull(result);            
            Assert.AreEqual(0, result.Count());            
        }

        [TestMethod]
        public void GetById()
        {
            // Disponer
            MessageController controller = new MessageController();

            // Actuar
            tblMessages result = controller.Get(0);

            // Declarar
            tblMessages entidadMessage = new tblMessages();
            Assert.IsNotNull(result);
            Assert.AreEqual(entidadMessage.MessageID, result.MessageID);
            Assert.AreEqual(entidadMessage.ToNumber, result.ToNumber);
            Assert.AreEqual(entidadMessage.DateCreated, result.DateCreated);
            Assert.AreEqual(entidadMessage.Message, result.Message);
            Assert.IsInstanceOfType(result, typeof(tblMessages));

        }
        [TestMethod]
        public void Post()
        {
            // Disponer
            MessageController controller = new MessageController();

            // Actuar
            tblMessages tblMensageTest = new tblMessages()
            {
                MessageID = 0,
                Message = "Unit Test",
                DateCreated = DateTime.Now,
                ToNumber = "+50377777777"                
            };
            tblMessages result = controller.Post(tblMensageTest);

            // Declarar       
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(tblMessages));
            Assert.IsTrue(result.MessageID > 0);
            Assert.IsInstanceOfType(result.DateCreated, typeof(DateTime));           

        }
       
    }
}

