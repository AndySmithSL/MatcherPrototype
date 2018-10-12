using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatcherPrototype
{
    public class Account
    {
        private int accountNumber = default(int);

        private string name = null;

        public int AccountNumber
        {
            get => accountNumber;
            set => accountNumber = value;
        }

        public string Name
        {
            get => name ?? (name = string.Empty);
            set => name = value;
        }

        public Account(int accountNumber) : this(accountNumber, "Guest") { }

        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }
    }
}
