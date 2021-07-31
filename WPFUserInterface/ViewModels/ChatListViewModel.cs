
using System.Collections.Generic;
using WPFUserInterface.Models;

namespace WPFUserInterface.ViewModels
{
    class ChatListViewModel
    {
        public ChatListViewModel()
        {

        }
        public List<ChatListItems> ChatListItems
        {

            get
            {
                return new List<ChatListItems>
                {
                new ChatListItems(){ ContactName="Dino", DisplayLetters="D",LastMessageTime="10:30 PM", Availability="Online", IsRead=true, Message="work on this is so annoying!", NewMsgCount="1", IsOnline=true},
                new ChatListItems() { ContactName = "Anna Dormun", DisplayLetters="AD", LastMessageTime = "14:45 pm", Availability = "Offline", Message = "Its seems logical that the strategy of providing!", ContactProfilePic="/assets/profile1.jpg" },
                new ChatListItems() {IsChatSelected=true, ContactName = "Tobias Williams", DisplayLetters="TW",LastMessageTime = "06:18 am", Availability = "Offline", Message = "I remember everything mate. See you later", IsRead = false, ContactProfilePic="/assets/profile1.jpg"},
                new ChatListItems() { ContactName = "Jennifer Watkins", DisplayLetters="JW",LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false , ContactProfilePic="/assets/profile1.jpg", IsOnline=true}
                };
            }
        }

    }
}
