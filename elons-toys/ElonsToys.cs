using System;

class RemoteControlCar
{
    private int CurrentDistance = 0;
    private int CurrentBatteryPercentege = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {CurrentDistance} meters";
        
    }

    public string BatteryDisplay()
    {
        if(CurrentBatteryPercentege <= 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {CurrentBatteryPercentege}%";
        }
    }

    public void Drive()
    {
        if(CurrentBatteryPercentege > 0)
        {
            CurrentDistance += 20;
            CurrentBatteryPercentege -= 1;
        }
    }
}
