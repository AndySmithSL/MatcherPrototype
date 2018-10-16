using MatcherPrototype.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace MatcherPrototype.Classes.Tests
{
    [TestClass()]
    public class AccountManagerTests
    {
        #region Properties

        public IAccountManager Target { get; set; }
        public Mock<IAccount> MockAccount { get; set; }
        public IList<IAccount> Accounts { get; set; }

        #endregion Properties

        #region Initialise

        [TestInitialize]
        public void Startup()
        {
            //Mock account and accounts list
            MockAccount = SetupMockAccount("Account Number", "Name");
            Accounts = new List<IAccount>() { MockAccount.Object };
        
            Target = new AccountManager();
        }

        private Mock<IAccount> SetupMockAccount(string accountNumber, string name)
        {
            Mock<IAccount> result = new Mock<IAccount>();
            result.Setup(a => a.AccountNumber).Returns(accountNumber);
            result.Setup(a => a.Name).Returns(name);

            return result;
        }

        #endregion Initialise

        #region Accounts

        [TestMethod()]
        public void Accounts_AccountsSet_ReturnsSetAccounts()
        {
            IList<IAccount> expected = new List<IAccount>();
            Target.Accounts = expected;
            Assert.AreEqual(expected, Target.Accounts);
        }

        [TestMethod()]
        public void Accounts_AccountsNotSet_ReturnsList()
        {
            Assert.IsInstanceOfType(Target.Accounts, typeof(IList<IAccount>));
        }

        [TestMethod()]
        public void Accounts_AccountsNotSet_ReturnsEmptyList()
        {
            Assert.AreEqual(0, Target.Accounts.Count);
        }

        #endregion Accounts

        #region CreateAccount

        [TestMethod()]
        public void CreateAccount_SetName_ResultIsNotNull()
        {
            Assert.IsNotNull(Target.CreateAccount("myName"));
        }

        [TestMethod()]
        public void CreateAccount_SetName_ReturnsAccountWithCorrectName()
        {
            Assert.AreEqual("myName", Target.CreateAccount("myName").Name);
        }

        [TestMethod()]
        public void CreateAccount_SetNameAndAccountNumber_ResultIsNotNull()
        {
            Assert.IsNotNull(Target.CreateAccount("myAccountNumber", "myName"));
        }

        [TestMethod()]
        public void CreateAccount_SetNameAndAccountNumber_ReturnsAccountWithCorrectAccountNumber()
        {
            Assert.AreEqual("myAccountNumber", Target.CreateAccount("myAccountNumber", "myName").AccountNumber);
        }

        [TestMethod()]
        public void CreateAccount_SetNameAndAccountNumber_ReturnsAccountWithCorrectName()
        {
            Assert.AreEqual("myName", Target.CreateAccount("myAccountNumber", "myName").Name);
        }

        [TestMethod()]
        public void CreateAccount_SetNameAndAccountNumber_AddsNewAccountToAccounts()
        {
            IAccount result = Target.CreateAccount("myAccountNumber", "myName");
            Assert.AreEqual(1, Target.Accounts.Count);
        }

        #endregion CreateAccount

        #region FindAccountByAccountNumber

        [TestMethod()]
        public void FindAccountByAccountNumber_NoAccounts_ReturnsNull()
        {
            IAccount result = Target.FindAccountByAccountNumber("x");
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void FindAccountByAccountNumber_HasAccountsButNoMatch_ReturnsNull()
        {
            //Inject
            Target.Accounts = Accounts;

            //Test
            IAccount result = Target.FindAccountByAccountNumber("z");
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void FindAccountByAccountNumber_HasAccountsWithMatch_ReturnsAccountNotNull()
        {
            Target.Accounts = Accounts;
            IAccount result = Target.FindAccountByAccountNumber("Account Number");
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void FindAccountByAccountNumber_HasAccountsWithMatch_ReturnsCorrectAccount()
        {
            Target.Accounts = Accounts;
            IAccount result = Target.FindAccountByAccountNumber("Account Number");
            Assert.AreEqual(MockAccount.Object, result);
        }

        #endregion FindAccountByAccountNumber

        #region FindAccountByName

        [TestMethod()]
        public void FindAccountByName_NoAccounts_ReturnsNull()
        {
            IAccount result = Target.FindAccountByName("x");
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void FindAccountByName_HasAccountsButNoMatch_ReturnsNull()
        {
            //Inject
            Target.Accounts = Accounts;

            //Test
            IAccount result = Target.FindAccountByName("z");
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void FindAccountByName_HasAccountsWithMatch_ReturnsAccountNotNull()
        {
            Target.Accounts = Accounts;
            IAccount result = Target.FindAccountByName("Name");
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void FindAccountByName_HasAccountsWithMatch_ReturnsCorrectAccount()
        {
            Target.Accounts = Accounts;
            IAccount result = Target.FindAccountByName("Name");
            Assert.AreEqual(MockAccount.Object, result);
        }

        #endregion FindAccountByName

    }
}