// See https://aka.ms/new-console-template for more information
using SimpleException;
using System.Collections;

Console.WriteLine("***** Simple Exception Example -  294 *****");
Console.WriteLine("=> Create a car and step on it!");

Car myCar = new("Zippy", 20);

myCar.CrankTunes(true);

try {
    for (int i = 0; i < 10; i++) {
        myCar.Accelerate(10);
    }
}
catch (Exception ex) {
    ex.Data["TimeStamp"] = $"the car exploded at {DateTime.Now}";
    ex.Data["Cause"] = "You have a lead foot.";
    Console.WriteLine("***** Error! *****");
    Console.WriteLine($"Method: {ex.TargetSite}");
    Console.WriteLine($"Class defining memeber: {ex.TargetSite?.DeclaringType}");
    Console.WriteLine($"Member type: {ex.TargetSite?.MemberType}");
    Console.WriteLine($"Member name: {ex.TargetSite}");
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"Source: {ex.Source}");
    Console.WriteLine($"Stack: {ex.StackTrace}");
    ex.HelpLink = "https://CarsRUs.com";
    Console.WriteLine($"Link: {ex.HelpLink}");

    foreach (DictionaryEntry data in ex.Data) {
        Console.WriteLine($"{data.Key}: {data.Value}");
    }
}

Console.WriteLine("\n***** Out of exception logic *****");

Console.ReadLine();
