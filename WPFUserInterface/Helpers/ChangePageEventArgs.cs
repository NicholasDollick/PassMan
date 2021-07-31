using System;

namespace WPFUserInterface.Helpers
{
    class ChangePageEventArgs : EventArgs
    {
        public Type NextPage { get; set; }
        public string[] StringProperties { get; set; }
    }
}
