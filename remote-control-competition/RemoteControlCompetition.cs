using System;
using System.Collections.Generic;

// TODO implement the IRemoteControlCar interface

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }

    public int CompareTo(object obj)
    {
        var other =(ProductionRemoteControlCar)obj;
        return this.NumberOfVictories.CompareTo(other.NumberOfVictories);
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var list = new List<ProductionRemoteControlCar>();
        list.Add(prc1);
        list.Add(prc2);
        list.Sort();
        return list;
    }
}

public interface IRemoteControlCar
{
    int DistanceTravelled { get; set; }
    void Drive();
}