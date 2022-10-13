using System;


public abstract class Car
{
    public string CarType { get; protected set; }
    public double AverageFuelConsumption { get; protected set; }
    public double FuelTankCapacity { get; protected set; }
    public double CurrentFuel { get; protected set; }
    public double Speed { get; protected set; }

    public Car(string carType, double averageFuelConsumption, double fuelTankCapacity,
        double currentFuel, double speed)
    {
        CarType = carType;
        AverageFuelConsumption = averageFuelConsumption;
        FuelTankCapacity = fuelTankCapacity;
        CurrentFuel = currentFuel;
        Speed = speed;
    }

    public void DisplayCurrentFuelRange()
    {
        Console.WriteLine($"Текущий запас хода равен {CalcFuelRangeOfCurrentFuel()}");
    }
    public double CalcTimeToCoverDistance(double distance)
    {
        return distance / Speed;
    }
    public double CalcFuelRangeOfFullFuelTack()
    {
        return CalcFuelRange(FuelTankCapacity);
    }
    public double CalcFuelRangeOfCurrentFuel()
    {
        return CalcFuelRange(CurrentFuel);
    }
    protected virtual double CalcFuelRange(double fuel)
    {
        return fuel / AverageFuelConsumption;
    }
}
