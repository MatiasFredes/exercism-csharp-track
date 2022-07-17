using System;

class BirdCount
{
    private static int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return birdsLastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int countBirds in birdsPerDay)
        {
            if(countBirds == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for(int i = 0; i < numberOfDays; i++)
        {
            total += birdsPerDay[i];
        }

        return total;
    }

    public int BusyDays()
    {
        int total = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if(birdsPerDay[i] >= 5)
            {
                total += 1;
            }
        }

        return total;
    }
}
