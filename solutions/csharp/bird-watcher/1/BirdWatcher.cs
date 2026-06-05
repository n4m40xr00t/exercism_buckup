class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        if (birdsPerDay.Length != 0) {
            birdsPerDay[birdsPerDay.Length - 1]++;
        }
    }

    public bool HasDayWithoutBirds()
    {
        bool _checked = false;
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
            {
                _checked = true;
            }
        }
        return _checked;
    }

    public int CountForFirstDays(int numberOfDays) { 

        if (numberOfDays >= birdsPerDay.Length)
        {
            numberOfDays = birdsPerDay.Length;
        }

        int _sumOfBirdCount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            _sumOfBirdCount += birdsPerDay[i];
        }
        return _sumOfBirdCount;
    }

    public int BusyDays()
    {
        int _numberOfBusyDays = 0;
        foreach (int day in birdsPerDay)
        {
            if (day >= 5)
            {
                _numberOfBusyDays++;
            }
        }
        return _numberOfBusyDays;
    }
}
