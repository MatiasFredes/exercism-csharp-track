using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int bateryStatus;
    private int distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.bateryStatus = 100;
        this.distanceDriven = 0;
    }

    // TODO: define the constructor for the 'RemoteControlCar' class

    public bool BatteryDrained()
    {
        return bateryStatus < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            bateryStatus -= batteryDrain;
            distanceDriven += speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    // TODO: define the constructor for the 'RaceTrack' class

    public bool TryFinishTrack(RemoteControlCar car)
    {
       while(distance > car.DistanceDriven())
        {
            if (car.BatteryDrained())
            {
                return false;
            }
            car.Drive();
           
        }

        return true;
    }
}
