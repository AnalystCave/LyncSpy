using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Conversation;
using Microsoft.Lync.Model.Extensibility;

namespace LyncTracker.Logic
{
    class Tracker
    {
        ChangeInterface _cn;
        List<Contact> _cList = new List<Contact>();
        LyncClient _lc = LyncClient.GetClient();
        List<ContactAvailability> _statusList;

        public Tracker(ChangeInterface cn)
        {
            _lc = LyncClient.GetClient();
            _cn=cn;

            _lc.ConversationManager.ConversationAdded += ConversationManager_ConversationAdded;
            _lc.ConversationManager.ConversationRemoved += ConversationManager_ConversationRemoved;
    
        }

        void Callback(IAsyncResult ar)
        {
            int x = 1;
            try
            {
                
                Automation _Automation = LyncClient.GetAutomation();
                

                SearchResults sr = _lc.ContactManager.EndSearch(ar);
                Contact c = sr.Contacts.First();
                _cList.Add(c);
                c.ContactInformationChanged+= c_ContactInformationChanged;
                ContactAvailability availEnum = (ContactAvailability)c.GetContactInformation(ContactInformationType.Availability);
                _cn.SendStatusChange((string)((List<object>)c.GetContactInformation(ContactInformationType.EmailAddresses)).First(), availEnum);
            }
            catch
            {
            }
        }

        void ConversationManager_ConversationRemoved(object sender, ConversationManagerEventArgs e)
        {
            //MessageBox.Show("Removed");
            
        }

        void ConversationManager_ConversationAdded(object sender, ConversationManagerEventArgs e)
        {
            e.Conversation.ContextDataReceived += Conversation_ContextDataReceived;
            e.Conversation.ContextDataSent += Conversation_ContextDataSent;
            e.Conversation.ParticipantAdded +=Conversation_ParticipantAdded;
            //MessageBox.Show("Added");

        }

        void Conversation_ParticipantAdded(object sender, ParticipantCollectionChangedEventArgs e)
        {
            if (e.Participant.IsSelf)
            {
            }
            else
            {
                if (((Conversation)sender).Modalities.ContainsKey(ModalityTypes.InstantMessage))
                {
                    ((InstantMessageModality)e.Participant.Modalities[ModalityTypes.InstantMessage]).InstantMessageReceived += Tracker_InstantMessageReceived;

                }
            }
        }

        void Tracker_InstantMessageReceived(object sender, MessageSentEventArgs e)
        {
            //MessageBox.Show(e.Text);
        } 

        void Conversation_ContextDataSent(object sender, ContextEventArgs e)
        {
            //MessageBox.Show("Sent");
        }

        void Conversation_ContextDataReceived(object sender, ContextEventArgs e)
        {
            //MessageBox.Show("Received");
        }

        void c_ContactInformationChanged(object sender, ContactInformationChangedEventArgs e)
        {
            if (e.ChangedContactInformation.Contains(ContactInformationType.Availability))
            {
                try
                {

                    ContactAvailability availEnum = (ContactAvailability)((Contact)sender).GetContactInformation(ContactInformationType.Availability);
                    if (!CheckStatus(availEnum)) return;
                    string activityString = (string)((Contact)sender).GetContactInformation(ContactInformationType.Activity);
                    //var availability = ((Contact)sender).GetContactInformation(ContactInformationType.Availability);
                    var customActivity = ((Contact)sender).GetContactInformation(ContactInformationType.CustomActivity);
                    var locName = ((Contact)sender).GetContactInformation(ContactInformationType.LocationName);
                    var title = ((Contact)sender).GetContactInformation(ContactInformationType.Title);
                    var defNote = ((Contact)sender).GetContactInformation(ContactInformationType.DefaultNote);
                    var desc = ((Contact)sender).GetContactInformation(ContactInformationType.Description);
                    var actId = ((Contact)sender).GetContactInformation(ContactInformationType.ActivityId);
                    var cap = ((Contact)sender).GetContactInformation(ContactInformationType.Capabilities);
                    var capStr = ((Contact)sender).GetContactInformation(ContactInformationType.CapabilityString);
                    var calState = ((Contact)sender).GetContactInformation(ContactInformationType.CurrentCalendarState);
                    var idleStartTime = ((Contact)sender).GetContactInformation(ContactInformationType.IdleStartTime);
                    var nextCalStartTime = ((Contact)sender).GetContactInformation(ContactInformationType.NextCalendarStateStartTime);
                    var timeZone = ((Contact)sender).GetContactInformation(ContactInformationType.TimeZone);
                    var availID = ((Contact)sender).GetContactInformation(ContactInformationType.ActivityId);

                    Contact c = ((Contact)sender);
                    List<object> list = (List<object>)(((Contact)sender).GetContactInformation(ContactInformationType.EmailAddresses));
                    _cn.SendStatusChange((string)list.First(), ((string)c.GetContactInformation(ContactInformationType.LastName)),
                                        ((string)c.GetContactInformation(ContactInformationType.FirstName)),
                                        availEnum, DateTime.Now.ToLocalTime());
                }
                catch { }
            }
            
        }

        private bool CheckStatus(ContactAvailability availEnum)
        {  
            foreach (ContactAvailability ca in _statusList)
            {
                if (ca == availEnum)
                    return true;
            }
            return false;
        }

        public void Start(List<string> sList, List<ContactAvailability> statusList)
        {
            _statusList = statusList;
            foreach (string s in sList)
            {
                IAsyncResult ar = _lc.ContactManager.BeginSearch(s, Callback, null);
            }
            _cn.SetStatus("On");
        }

        public void Stop()
        {
            foreach (Contact c in _cList)
            {
                c.ContactInformationChanged -= c_ContactInformationChanged;
            }
        }
    }
}
