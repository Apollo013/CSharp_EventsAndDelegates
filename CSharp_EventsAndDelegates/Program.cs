using CSharp_EventsAndDelegates.Events;
using CSharp_EventsAndDelegates.Repository;
using CSharp_EventsAndDelegates.Services;
using System;

namespace CSharp_EventsAndDelegates
{
    class Program
    {
        //private static Dictionary<string, Account> accounts;

        static void Main(string[] args)
        {
            // Local vars
            AccountProcessor processor = new AccountProcessor();
            AccountRepository accounts = new AccountRepository();
            MailService mailer = new MailService();

            // Add subscribers
            processor.AccountProcessed += mailer.OnAccountProcesed;


            // Process Accounts
            foreach (var account in accounts.Accounts)
            {
                processor.Process(account);
            }

            Console.ReadKey();
        }
    }
}
