using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Messenger.API.Models
{
    public class Config
    {
        public int ConfigID { get; set; }
        public string NameKey { get; set; }
        public string KeyValue { get; set; }
    }
}