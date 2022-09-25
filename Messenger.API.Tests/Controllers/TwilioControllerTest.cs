using Messenger.API.Controllers;
using Messenger.Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace Messenger.API.Tests.Controllers
{
    /// <summary>
    /// Descripción resumida de TwilioControllerTest
    /// </summary>
    [TestClass]
    public class TwilioControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Disponer
            TwilioController controller = new TwilioController();

            // Actuar
            tblMessages tblMensageTest = new tblMessages()
            {
                MessageID = 24,
                Message = "Unit Test",
                DateCreated = DateTime.Now,
                ToNumber = "+50377425139"
            };
            tblMessagesSend result = controller.Post(tblMensageTest);

            // Declarar
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(tblMessagesSend));
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseJSON));
            Assert.IsNotNull(result.ResponseJSON, "No Response Twilio");
        }
    }
}
