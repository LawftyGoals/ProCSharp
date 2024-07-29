

using System.Numerics;
using System;


namespace StaticDataAndMembers;
class SavingsAccount {

    public static double currInterestRate;

    public double currBalance;
    public SavingsAccount(double balance) {
        currInterestRate = 0.04d;
        currBalance = balance;
    }

    static SavingsAccount() {
        //Simply put, a static constructor is a special constructor that is an ideal place to initialize the values of
        //static data when the value is not known at compile time(e.g., you need to read in the value from an external
        //file, read in the value from a database, generate a random number, or whatnot).
        Console.WriteLine("static ctor");
        currInterestRate = 0.04d;
    }

    public static void SetInterestRate(double newRate) => currInterestRate = newRate;

    public static double GetInterestRate() => currInterestRate;

}

