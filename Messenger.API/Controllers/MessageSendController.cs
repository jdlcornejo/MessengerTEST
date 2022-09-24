using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Messenger.Data.Model;
using System.Data.Entity;
using Messenger.API.Models;

namespace Messenger.API.Controllers
{
    public class MessageSendController : ApiController
    {
        private MessageEntities db = new MessageEntities();

        //Method for get List Result Twilio and Show in UI for JSON
        public MessagesSend Get(int id)
        {
            MessagesSend message;
            try
            {
                var Querymessage = db.tblMessagesSend.Where(x=>x.MessageID == id).FirstOrDefault();
                message = new MessagesSend() {
                MessageID = Querymessage.MessageID,
                MessageSendID = Querymessage.MessageSendID,
                DateSent = Querymessage.DateSent,
                ConfirmatedCode = Querymessage.ConfirmatedCode,
                ResponseJSON = Querymessage.ResponseJSON
                };

            }
            catch (Exception ex)
            {
                message = new MessagesSend();
            }

            return message;
        }

        //Method for post for save change the details message in tblMessageSend
        public tblMessagesSend Post([FromBody] tblMessagesSend message)
        {
            try
            {
                db.tblMessagesSend.Add(message);
                db.SaveChanges();
                if (message.MessageSendID == 0)
                {
                    return new tblMessagesSend();
                }
                return message;

            }
            catch (Exception ex)
            {
                return new tblMessagesSend();
            }

        }

    }
}