using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Messenger.Data.Model;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Messenger.API.Controllers
{
    public class TwilioController : ApiController
    {
        private MessageEntities db = new MessageEntities();
     


        // Method for Send Post API from Twilio
        public tblMessagesSend Post([FromBody] tblMessages pMessage)
        {

            var queryaccountSid = db.tblConfig.Where(x => x.NameKey == "accountSid").FirstOrDefault<tblConfig>();
            var queryauthToken = db.tblConfig.Where(x => x.NameKey == "authToken").FirstOrDefault<tblConfig>();
            var queryMessagingServiceSid = db.tblConfig.Where(x => x.NameKey == "messagingServiceSid").FirstOrDefault<tblConfig>();


            string accountSid = queryaccountSid.KeyValue;
            string authToken = queryauthToken.KeyValue;
            TwilioClient.Init(accountSid, authToken);

            CreateMessageOptions messageOptions = new CreateMessageOptions(                 
                        new PhoneNumber(pMessage.ToNumber))
            {
                MessagingServiceSid = queryMessagingServiceSid.KeyValue,
                Body = pMessage.Message
            };

            MessageResource message = MessageResource.Create(messageOptions);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = true
            };
            string responseMessageJsonWithoutNull = JsonSerializer.Serialize(message, options);


            tblMessagesSend tblMessagesSendReturn = new tblMessagesSend()
            {
                MessageID = pMessage.MessageID,
                ConfirmatedCode = message.AccountSid,
                DateSent = Convert.ToDateTime(message.DateCreated),
                ResponseJSON = responseMessageJsonWithoutNull
            };

            return tblMessagesSendReturn;

        }

    }
}