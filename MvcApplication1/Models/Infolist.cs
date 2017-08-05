using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Infolist
    {
       public List<Account> Accounts;

        public Infolist()
        { 

         Accounts = new List<Account>();

         Accounts.Add(new Account { ID = 1,name = "My name1",age = 12});
         Accounts.Add(new Account { ID = 2, name = "My name2", age = 13 });
         Accounts.Add(new Account { ID = 3, name = "My name3", age = 14 });
        }
    }
}