using System;
using System.Windows.Input;
using WPFUserInterface.Helpers;

namespace WPFUserInterface.Models
{
    class VaultItem
    {
        public bool IsEntrySelected { get; set; }
        public string EntryVisibility { get; set; }

        //public string ContactProfilePic { get; set; }

        public string EntryName { get; set; }

        // this will be an image later
        public string DisplayLetters { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Note { get; set; }
    }
}
