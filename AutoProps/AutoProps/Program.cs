// See https://aka.ms/new-console-template for more information
using AutoProps;

Console.WriteLine("***** Fun with Automatic Properties *****\n");


Car newCar = new();
newCar.PetName = "Mac";
newCar.Speed = 30;
newCar.Color = "Hot Pink Baby!";


Console.WriteLine($"Your car is named {newCar.PetName}? Thats cool.");

newCar.DisplayStats();


Garage g = new();

// works because default 0
Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);

// works not without initialized value in class, because by default set properties of object to null
//Console.WriteLine("Number of Cars: {0}", g.MyAuto.PetName);

g.MyAuto = newCar;

Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
Console.WriteLine("Number of Cars: {0}", g.MyAuto.PetName);


Console.ReadLine();