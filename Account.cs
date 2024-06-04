using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using NUnit.Framework;
using System.Security.Principal;
using NUnit.Framework.Legacy;

public class Account
{
    public double Balance { get; private set; }
    public double OverdraftLimit { get; private set; }

    public Account(double overdraftLimit)
    {
        this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
        this.Balance = 0;
    }

    public bool Deposit(double amount)
    {
        if (amount >= 0)
        {
            this.Balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(double amount)
    {
        if (this.Balance - amount >= -this.OverdraftLimit && amount >= 0)
        {
            this.Balance -= amount;
            return true;
        }
        return false;
    }
}

[TestFixture]
public class Tester
{
    private double epsilon = 1e-6;

    [Test]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        
        Account account = new Account(-20);

        ClassicAssert.AreEqual(0, account.OverdraftLimit, epsilon);
    }

    [Test]
    public void AccountCannotOverstepItsOverdraftLimit()
    {
        Account account = new Account(20);
        account.Withdraw(25);
        ClassicAssert.AreEqual(20, account.Balance, epsilon);
    }



    [Test]
    public void DepositAndWithrawWillWorkWithCorrectAmount()
    {
        Account account = new Account(20);
        account.Withdraw(5);
        ClassicAssert.AreEqual(15, account.Balance, epsilon);

        account.Deposit(7);
        ClassicAssert.AreEqual(22, account.Balance, epsilon);

    }


}

/*class Program
{
    static void Main(string[] args)
    {
        // This is just to make the program runnable.
        // Normally, you would use a test runner to run the tests.
        Console.WriteLine("Run the tests using a test runner.");
    }
}
*/
