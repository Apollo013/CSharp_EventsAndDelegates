using CSharp_EventsAndDelegates.Events;
using System;

namespace CSharp_EventsAndDelegates.Services
{
    /// <summary>
    /// Subscriber to AccountProcessed event
    /// </summary>
    public class MailService
    {
        public void OnAccountProcesed(object source, AccountEventArgs e)
        {
            Console.WriteLine($"Processed Account'{e.Account.AccountId}' for {e.Account.Person.Name}");
        }
    }
}
