using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Messenger.Data.Model;

namespace Messenger.API.Service
{
    public class TwilioService : ITwilioService
    {

        public MessageResource SendMessageByTwilio(tblMessages pMessage) 
        {

            var accountSid = "ACc69c1a91e3414f30edc24ab30973b1a9";
            var authToken = "9c30855abd19a61f4a11b39a2ddb50dc";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("+50377425139"));
            messageOptions.MessagingServiceSid = "MG4c3641885324df1a1f1a2d47f3b6442d";
            messageOptions.Body = "Prueba";
            

            var message = MessageResource.Create(messageOptions);

            return message;
            

        }


    }
}