using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float InterestRating = 0;

        if (balance < 0)
        {
            InterestRating = 3.213f;
        }
        else if (balance >= 0 && balance < 1000)
        {
            InterestRating = 0.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            InterestRating = 1.621f;
        }
        else if (balance >= 5000)
        {
            InterestRating = 2.475f;
        }

        return InterestRating;
    }

    public static decimal Interest(decimal balance)
    {
        float InterestRating = InterestRate(balance);
        return balance * (decimal)(InterestRating / 100f);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int numberOfYears = 0;

        // The while loop checks the condition first. 
        // If balance >= targetBalance right away, it skips the loop and returns 0.
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance); // Reused your update method here!
            numberOfYears++;
        }

        return numberOfYears;
    }
}