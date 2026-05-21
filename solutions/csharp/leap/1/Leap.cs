public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            // If it's divisible by 100, it must ALSO be divisible by 400
            if (year % 100 == 0)
            {
                return year % 400 == 0; 
            }
            
            // Divisible by 4 but not 100? Definitely a leap year.
            return true;
        }
        
        return false;
    }
}