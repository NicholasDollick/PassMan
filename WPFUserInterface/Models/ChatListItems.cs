
namespace WPFUserInterface.Models
{
    class ChatListItems
    {
        public bool IsChatSelected { get; set; }

        public bool IsOnline { get; set; }

        public string ContactProfilePic { get; set; }

        public string ContactName { get; set; }
        
        public string DisplayLetters { get; set; }

        public string LastMessageTime { get; set; }

        public string Availability { get; set; }

        public bool IsRead { get; set; }

        public string Message { get; set; }

        public string NewMsgCount { get; set; }
    }
}
