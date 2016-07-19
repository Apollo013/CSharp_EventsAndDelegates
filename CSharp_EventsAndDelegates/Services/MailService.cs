using CSharp_EventsAndDelegates.Events;
using System;

namespace CSharp_EventsAndDelegates.Services
{
    public class MailService
    {
        public void OnAccountProcesed(object source, AccountEventArgs e)
        {
            Console.WriteLine($"Processed Account'{e.Account.AccountId}' for {e.Account.Person.Name}");
        }
    }
}
