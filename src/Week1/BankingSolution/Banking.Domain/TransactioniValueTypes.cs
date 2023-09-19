namespace Banking.Domain;
public record TransactioniValueTypes
{
    public record Deposit : TransactioniValueTypes { }
    public record Withdrawl : TransactioniValueTypes { }
    public record Balance : TransactioniValueTypes { }

}



// Deposite (decimal amount)
// Withdraw (decimal amount)
// GetBalance => decimal