using Messenger.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Messenger.API.Service
{
    public interface ITwilioService
    {
       MessageResource SendMessageByTwilio(tblMessages pMessage);
    }
}
