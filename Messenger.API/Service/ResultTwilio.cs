using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Messenger.API.Service
{
    public class ResultTwilio
    {
        public string body { get; set; }
        public string num_segments { get; set; }
        public string direction { get; set; }
        public string from { get; set; }
        public string date_updated { get; set; }
        public string price { get; set; }
        public string error_message { get; set; }
        public string uri { get; set; }
        public string account_sid { get; set; }
        public string num_media { get; set; }
        public string to { get; set; }
        public string date_created { get; set; }
        public string status { get; set; }
        public string sid { get; set; }
        public string date_sen { get; set; }
        public string messaging_service_sid { get; set; }
        public string error_code { get; set; }
        public string price_unit { get; set; }
        public string api_version { get; set; }
        public string subresource_uris { get; set; }

    }
}