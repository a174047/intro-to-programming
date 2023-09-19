namespace Banking.Domain;

public class Account
{
    private decimal _balance = 5000M;
    public void Deposit(TransactioniValueTypes.Deposit amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public TransactioniValueTypes.Balance GetBalance()
    {
        return _balance;
    }

    public void Withdraw(TransactioniValueTypes.Withdrawl amountToWithdraw)
    {
        GuardHasSufficientFunds(amountToWithdraw);

        _balance -= amountToWithdraw; // The important business!

    }

    private void GuardHasSufficientFunds(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new OverdraftException();
        }
    }
}
