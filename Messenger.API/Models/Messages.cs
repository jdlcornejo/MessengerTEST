using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Messenger.API.Models
{
    public class Messages
    {
        [DisplayName("ID")]
        public int MessageID { get; set; }
        [DisplayName("DATE CREATED")]
        public System.DateTime DateCreated { get; set; }
        [DisplayName("TO PHONE NUMBER")]
        public string ToNumber { get; set; }
        [DisplayName("MESSAGE")]
        public string Message { get; set; }        
            
        
    }
}