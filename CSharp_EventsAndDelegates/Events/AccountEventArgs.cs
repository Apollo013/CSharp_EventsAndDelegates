using CSharp_EventsAndDelegates.Models;
using System;

namespace CSharp_EventsAndDelegates.Events
{
    public class AccountEventArgs : EventArgs
    {
        public Account Account { get; set; }
    }
}
