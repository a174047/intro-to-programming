﻿using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class MakingWithdrawls
{
    [Theory]
    [InlineData(82.23)]
    [InlineData(200)]
    public void MakingAWithdrawalDecreasesTheBalance(decimal amountToWithdraw)
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        //var amountToWithdraw = 80.23M;

        // When
        account.Withdraw(amountToWithdraw);

        // Then
        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void CanTakeEntireBalance()
    {
        var account = new Account();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }
}
