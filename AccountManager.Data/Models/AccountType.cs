using System;
using System.Collections.Generic;
using System.Text;
using AccountManager.Data.Core;

namespace AccountManager.Data.Models
{
    public class AccountType : ModelBase<int>
    {
        
        public string Codigo { get; set; }
        public string Name  { get; set; }

        public ICollection<Account> Accounts { get; set; }

    }
}
