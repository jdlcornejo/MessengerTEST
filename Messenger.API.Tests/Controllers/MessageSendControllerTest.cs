using Messenger.API.Controllers;
using Messenger.API.Models;
using Messenger.Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.API.Tests.Controllers
{
    /// <summary>
    /// Descripción resumida de MessageSendControllerTest
    /// </summary>
    [TestClass]
    public class MessageSendControllerTest
    {
        [TestMethod]
        public void GetById()
        {
            // Disponer
            MessageSendController controller = new MessageSendController();

            // Actuar
            MessagesSend result = controller.Get(0);

            // Declarar
            Assert.IsNotNull(result);
            MessagesSend entidadMessage = new MessagesSend();
            Assert.IsNotNull(result);
            Assert.AreEqual(entidadMessage.MessageID, result.MessageID);
            Assert.AreEqual(entidadMessage.MessageSendID, result.MessageSendID);
            Assert.AreEqual(entidadMessage.ResponseJSON, result.ResponseJSON);            
            Assert.IsInstanceOfType(result, typeof(MessagesSend));
        }
        [TestMethod]
        public void Post()
        {
            // Disponer
            MessageSendController controller = new MessageSendController();


            // Actuar

            tblMessagesSend tblMensageTest = new tblMessagesSend()
            {
                MessageID = 20,
                MessageSendID = 0,
                DateSent = DateTime.Now,
                ConfirmatedCode = "XXXXXXXXXXXXX",
                ResponseJSON = " []"
            };
            tblMessagesSend result = controller.Post(tblMensageTest);

            // Declarar       
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(tblMessagesSend));
            Assert.IsTrue(result.MessageID > 0);
            Assert.IsInstanceOfType(result.DateSent, typeof(DateTime));

        }

    }
}
