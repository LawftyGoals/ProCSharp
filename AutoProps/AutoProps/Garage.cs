﻿
namespace AutoProps;

internal class Garage
{
    public int NumberOfCars { get; set; } = 1;
    public Car MyAuto { get; set; } = new();

    public Garage()
    {
    }

    public Garage(Car car, int number)
    {
        MyAuto = car;
        NumberOfCars = number;
    }

}
