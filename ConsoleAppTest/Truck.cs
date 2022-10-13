using System;

public class Truck :Car
{
    public double CarryingCapacity;
    public double CurrentLoad;

    protected const double fuelRangeDecreaseForNKg = 0.04;
    protected const double n = 200;

    public Truck(double avgFuelConsumption, double fuelTankCapacity, double currFuel, double speed,
        double carryingCapacity, double currLoad)
        : base("Truck", avgFuelConsumption, fuelTankCapacity, currFuel, speed)
    {
        CarryingCapacity = carryingCapacity;
        CurrentLoad = currLoad;

        if (CurrentLoad > CarryingCapacity)
        {
            throw new ArgumentException($"Загруженность не может быть больше {CarryingCapacity}");
        }
    }

    protected override double CalcFuelRange(double fuel)
    {
        return base.CalcFuelRange(fuel) * (1 - CurrentLoad * (fuelRangeDecreaseForNKg / n));
    }
}
