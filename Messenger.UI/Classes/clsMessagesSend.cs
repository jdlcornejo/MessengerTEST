using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.UI.Classes
{
    class clsMessagesSend
    {
        public int MessageSendID { get; set; }
        public int MessageID { get; set; }
        public System.DateTime DateSent { get; set; }
        public string ConfirmatedCode { get; set; }
        public string ResponseJSON { get; set; }

    }
}
