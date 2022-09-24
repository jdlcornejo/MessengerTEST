using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.UI.EF
{
    class clsMessage
    {

      
        public int MessageID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string ToNumber { get; set; }
        public string Message { get; set; }
   
    }
}
