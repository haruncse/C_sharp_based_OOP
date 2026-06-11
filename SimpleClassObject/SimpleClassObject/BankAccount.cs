using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private decimal balance;
    // Constructor

    public BankAccount(decimal initialBalance) { 
        if (initialBalance >= 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Public method to deposit
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            //Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }

        GetBalance();
    }

    private decimal GetBalance()
    {
        Console.WriteLine("This is inside GetBalance");
        return balance;
    }


}

