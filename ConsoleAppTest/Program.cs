using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>()
        {
            new SportCar(2, 40, 8, 200),
            new PassengerCar(4, 30, 7, 200, 10, 6),
            new Truck(1, 20, 3, 200, 10000, 2000)
        };
        foreach (var car in cars)
        {
            car.DisplayCurrentFuelRange();
        }
    }
}