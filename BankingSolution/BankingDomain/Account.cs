﻿namespace Banking.Domain;
public class Account
{
    private decimal _balance = 5000;
    public void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return 5000M;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            return;
        }
        _balance += amountToWithdraw;
    }

}
