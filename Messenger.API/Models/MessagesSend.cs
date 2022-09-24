using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Messenger.API.Models
{
    public class MessagesSend
    {
        public int MessageSendID { get; set; }
        public int MessageID { get; set; }
        public System.DateTime DateSent { get; set; }
        public string ConfirmatedCode { get; set; }

        public string ResponseJSON { get; set; }
    }
}