using CSharp_EventsAndDelegates.Models;
using System.Collections.Generic;

namespace CSharp_EventsAndDelegates.Repository
{
    public class AccountRepository
    {
        public List<Account> Accounts { get; private set; }

        public PersonRepository People { get; set; }

        public AccountRepository()
        {
            People = new PersonRepository();
            Accounts = new List<Account>();
            CreateAccounts();
        }

        private void CreateAccounts()
        {
            Accounts.Add(new Account { AccountId = "1234", Person = People[1] });
            Accounts.Add(new Account { AccountId = "12345", Person = People[2] });
            Accounts.Add(new Account { AccountId = "12346", Person = People[3] });
            Accounts.Add(new Account { AccountId = "12347", Person = People[4] });
        }
    }
}
