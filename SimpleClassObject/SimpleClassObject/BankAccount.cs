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

}

