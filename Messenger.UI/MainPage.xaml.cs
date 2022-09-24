using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Messenger.UI.EF;
using Messenger.UI.Classes;
using Newtonsoft.Json;
using System.Text.RegularExpressions;


namespace Messenger.UI
{
   
    public sealed partial class MainPage : Page
    {
        public string apiURLTwilio = "http://localhost:63361/api/Twilio";
        public string apiURLMessage = "http://localhost:63361/api/Message";
        public string apiURLMessageSend = "http://localhost:63361/api/MessageSend";

        ApiHelper apiHelper = new ApiHelper();
        List<clsMessage> ListMessagesResult { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            getListMessage();

        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            TxtAlert.Text = string.Empty;
            string reg = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            Regex rgx = new Regex(reg);
            clsMessage messageResult = new clsMessage();
            clsMessagesSend twresult = new clsMessagesSend();
            string messagevalue = TxtMessage.Text.Trim();



            try
            {
                if (messagevalue.Length == 0) 
                {
                    TxtAlert.Text = "Please Type... \n";
                    return;
                }
                if (TxtPhoneNumber.Text.Length < 12 || !rgx.IsMatch(TxtPhoneNumber.Text))
                {
                    TxtAlert.Text = "Please Write a Correct Phone Number...";
                    return;
                }
                clsMessage message = new clsMessage()
                {
                    MessageID = 0,
                    Message = messagevalue,
                    ToNumber = TxtPhoneNumber.Text.Trim(),
                    DateCreated = DateTime.Now,
                };
                dynamic resultTwilioJSON = apiHelper.Post(apiURLTwilio, JsonConvert.SerializeObject(message));
                dynamic resultMessageJON = apiHelper.Post(apiURLMessage, JsonConvert.SerializeObject(message));
                if (resultMessageJON != null)
                {
                    messageResult = System.Text.Json.JsonSerializer.Deserialize<clsMessage>(Convert.ToString(resultMessageJON));
                }
                if (resultTwilioJSON != null)
                {
                    twresult = System.Text.Json.JsonSerializer.Deserialize<clsMessagesSend>(Convert.ToString(resultTwilioJSON));
                }
                if (twresult.ConfirmatedCode != null && messageResult.MessageID != 0)
                {
                    clsMessagesSend messagesSend = new clsMessagesSend() {
                        MessageSendID = 0,
                        MessageID = messageResult.MessageID,
                        DateSent = Convert.ToDateTime(twresult.DateSent),
                        ConfirmatedCode = twresult.ConfirmatedCode,
                        ResponseJSON = twresult.ResponseJSON
                    };
                    dynamic resultMessagesSend = apiHelper.Post(apiURLMessageSend, JsonConvert.SerializeObject(messagesSend));
                
                    TxtAlert.Text = "Message Sent...... OK!";
                }

                clearMessage();
                getListMessage();

            }
            catch (Exception ex) 
            {
                clearMessage();
                TxtAlert.Text = "Sorry! We have a problem right now, pleasa try again!";
            }

        }

        public void clearMessage() 
        {
            TxtMessage.Text = string.Empty;
            TxtPhoneNumber.Text = string.Empty;
        }

        public void getListMessage()
        {
            try
            {
                ListMessagesResult = new List<clsMessage>();
                dynamic result = apiHelper.Get("http://localhost:63361/api/Message/");             
                ListMessagesResult = System.Text.Json.JsonSerializer.Deserialize<List<clsMessage>>(Convert.ToString(result));
                gvListMessages.ItemsSource = ListMessagesResult;

            }
            catch (Exception ex) 
            {
                TxtAlert.Text = "Sorry! We have a problem right now, pleasa try again!";
            }

        }

        private void gvListMessages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clsMessagesSend messagesSend;
            try {

                if (e.AddedItems != null)
                {
                    clsMessage selectdMessage = (clsMessage)e.AddedItems[0];
                    dynamic result = apiHelper.Get(apiURLMessageSend + $"/{selectdMessage.MessageID}");
                    messagesSend = System.Text.Json.JsonSerializer.Deserialize<clsMessagesSend>(Convert.ToString(result));
                    TxtResponseJSON.Text = messagesSend.ResponseJSON;

                }
                else { TxtResponseJSON.Text =  "Choose one history message for details";  }
            } 
            catch (Exception ex) { TxtResponseJSON.Text = "Choose one history message for details";  }

        }
    }
}
