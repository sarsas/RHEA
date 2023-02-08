using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RHEA;
using Moq;
using System.Threading.Tasks;

namespace TestRHEA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            int accountId = 1;
            double expectedAmount = 1000.0;
            var accountServiceMock = new Mock<IAccountService>();
            accountServiceMock.Setup(x => x.GetAccountAmountAsync(accountId))
                .ReturnsAsync(expectedAmount);

            var accountInfo = new AccountInfo(accountId, accountServiceMock.Object);

            await accountInfo.RefreshAmountAsync();

            Assert.AreEqual(expectedAmount, accountInfo.Amount);
        }
    }
}

