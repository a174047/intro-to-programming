using Banking.Domain;
using NSubstitute;

namespace Banking.UnitTests.BankAccount;
public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveTheCorrectOpeningBalance()
    {
        // Write the code we wish we had
        // Given
        var account = new Account(Substitute.For<ICalculateBonusesForDeposits>());

        // When
        decimal balance = account.GetBalance();

        // Then
        Assert.Equal(5000M, balance);
    }
}
