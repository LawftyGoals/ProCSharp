// See https://aka.ms/new-console-template for more information
using StaticDataAndMembers;
using static StaticDataAndMembers.TimeUtilClass;

Console.WriteLine("***** Fun with Static Data *****\n");

SavingsAccount s1 = new(50);
SavingsAccount s2 = new(100);
SavingsAccount s3 = new(10000.75);

Console.WriteLine("***** Fun with Static Data *****\n");

SavingsAccount s4 = new(50);
SavingsAccount s5 = new(100);

Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);

SavingsAccount.InterestRate=0.06d;
SavingsAccount s6 = new(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);

PrintDate();
PrintTime();

Console.ReadLine();
