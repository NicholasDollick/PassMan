using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUserInterface.Models;

namespace WPFUserInterface.ViewModels
{
    class VaultListViewModel
    {
        public List<VaultItem> ChatListItems
        {

            get
            {
                return new List<VaultItem>
                {
                    new VaultItem() {IsEntrySelected=false, Username="test", DisplayLetters="FB", EntryName="Facebook"},
                    new VaultItem() {IsEntrySelected=true, Username="chungus123", DisplayLetters="GM", EntryName="Gmail"},
                    new VaultItem() {IsEntrySelected=false, Username="asdf", DisplayLetters="N", EntryName="name@company.com"}
                //new ChatListItems() { ContactName = "Anna Dormun", DisplayLetters="AD", LastMessageTime = "14:45 pm", Availability = "Offline", Message = "Its seems logical that the strategy of providing!", ContactProfilePic="/assets/profile1.jpg" },
                //new ChatListItems() {IsChatSelected=true, ContactName = "Tobias Williams", DisplayLetters="TW",LastMessageTime = "06:18 am", Availability = "Offline", Message = "I remember everything mate. See you later", IsRead = false, ContactProfilePic="/assets/profile1.jpg"},
                //new ChatListItems() { ContactName = "Jennifer Watkins", DisplayLetters="JW",LastMessageTime = "15 Sep 2019", Availability = "Online", Message = "I will miss you, too, my dear!", IsRead = false , ContactProfilePic="/assets/profile1.jpg", IsOnline=true}
                };
            }
        }

    }
}
