using CSharp_EventsAndDelegates.Models;
using System;
using System.Threading;

namespace CSharp_EventsAndDelegates.Events
{
    public class AccountProcessor
    {
        // USING seperate delegate and event declarations
        /*
        public delegate void AccountProcessedEventHandler(object source, AccountEventArgs args);

        public event AccountProcessedEventHandler AccountProcessed;
        */

        // Using sinngle EventHandler
        public EventHandler<AccountEventArgs> AccountProcessed;

        public void Process(Account account)
        {
            Console.WriteLine($"Processing Account:{account.AccountId}");
            Thread.Sleep(1000); // simulate some work
            OnAccountProcessed(account);
        }

        protected virtual void OnAccountProcessed(Account account)
        {
            AccountProcessed?.Invoke(this, new AccountEventArgs() { Account = account });
        }
    }
}
