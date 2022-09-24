using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Messenger.Data.Model;
using System.Data.Entity;
using Messenger.API.Models;

namespace Messenger.API.Controllers
{
    public class MessageController : ApiController
    {
        private MessageEntities db = new MessageEntities();
  
        public List<Messages> Get()
        {
            List<Messages> ListMessages;
            try {
                var query = db.tblMessages.Include(x => x.tblMessagesSend);
               return (from m in query
                              select new Messages()
                              {
                                  MessageID = m.MessageID,
                                  Message = m.Message,
                                  ToNumber =m.ToNumber,
                                  DateCreated = m.DateCreated
                              }).ToList();
            } 
            catch (Exception ex) 
            {
                ListMessages = new List<Messages>();
            }
            return ListMessages;
            
        }

        // GET api/Message/5
        public tblMessages Get(int id)
        {
            tblMessages message;
            try
            {
                message = db.tblMessages.Find(id);

            }
            catch (Exception ex)
            {
                message = new tblMessages();
            }

            return message;
        }

        // POST api/Message
        public tblMessages Post([FromBody] tblMessages message)
        {          
            try
            {
                db.tblMessages.Add(message);
                db.SaveChanges();                 
                if (message.MessageID == 0) 
                {
                    return new tblMessages();
                }

                return message;

            }
            catch (Exception ex) 
            {
                return new tblMessages();
            }
        }
       
    }
}