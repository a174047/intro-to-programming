using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class OverdraftNotAllowed
{
    [Fact]
    public void BalanceDoesNotDecreaseOnOverdraft()
    {
        // If you overdraft, what should be the "observable" thing that happens?
        // - it shouldn't decrease your balance.
        //    - if I have 5000, and I take out 6000, then I should still have 5000

        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();

        var ammountToWithdraw = account.GetBalance() + .01M;

        // When
        try
        {
            account.Withdraw(ammountToWithdraw);
        }
        catch (OverdraftException)
        {

            //throw
        }
        finally
        {
            // Then
            Assert.Equal(openingBalance, account.GetBalance());
        }

    }

    [Fact]
    public void OverdraftThrowsAnExcception()
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();

        var amountToWithdraw = account.GetBalance() + .01M;

        // When & Then
        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(amountToWithdraw);
        });

    }
}
