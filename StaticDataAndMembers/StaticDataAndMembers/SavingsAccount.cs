

using System.Numerics;
using System;


namespace StaticDataAndMembers;
class SavingsAccount {

    private static double _currInterestRate;

    public static double InterestRate
    {
        get => _currInterestRate;
        set => _currInterestRate = value;
    }


    public double currBalance;
    public SavingsAccount(double balance) {
        InterestRate = 0.04d;
        currBalance = balance;
    }

    static SavingsAccount() {
        //Simply put, a static constructor is a special constructor that is an ideal place to initialize the values of
        //static data when the value is not known at compile time(e.g., you need to read in the value from an external
        //file, read in the value from a database, generate a random number, or whatnot).
        Console.WriteLine("static ctor");
        InterestRate = 0.04d;
    }

    public static void SetInterestRate(double newRate) => InterestRate = newRate;

    public static double GetInterestRate() => InterestRate;

}

