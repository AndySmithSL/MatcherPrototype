using MatcherPrototype.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace MatcherPrototype.Classes.Tests
{
    [TestClass()]
    public class AccountTests
    {
        Mock<IAccountNumberGenerator> mockGenerator = null;

        public Mock<IAccountNumberGenerator> MockGenerator
        {
            get => mockGenerator ?? (mockGenerator = new Mock<IAccountNumberGenerator>());
            set => mockGenerator = value;
        }

        [TestInitialize]
        public void StartUp()
        {
            MockGenerator.Reset();
        }
        
        [TestMethod()]
        public void AccountNumber_AccountNumberNull_ReturnsNewAccountNumber()
        {
            //Arrange
            MockGenerator.Setup(g => g.Create()).Returns("12345678");
            IAccount account = new Account();
            account.Generator = MockGenerator.Object;

            //Act & Assert
            Assert.AreEqual("12345678", account.AccountNumber);
        }

        [TestMethod()]
        public void AccountNumber_AccountNumberSet_ReturnsSetAccountNumber()
        {
            IAccount account = new Account("87654321", "X");
            Assert.AreEqual("87654321", account.AccountNumber);
        }

        [TestMethod()]
        public void Name_NameSet_ReturnsSetName()
        {
            string name = "Dan Carter";
            IAccount account = new Account("87654321", name);
            Assert.AreEqual(name, account.Name);
        }

        [TestMethod()]
        public void Name_NameNotSet_ReturnsNullReferenceException()
        {
            IAccount account = new Account();
            Assert.ThrowsException<NullReferenceException>(() => account.Name);
        }

        [TestMethod()]
        public void Generator_GeneratorSet_ReturnsSetGenerator()
        {
            IAccount account = new Account();
            account.Generator = MockGenerator.Object;

            Assert.AreSame(MockGenerator.Object, account.Generator);
        }
    }
}