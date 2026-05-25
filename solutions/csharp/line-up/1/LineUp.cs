public static class LineUp
{
    public static string Format(string name, int number)
    {
        return String.Format("{0}, you are the {1}{2} customer we serve today. Thank you!", name, number, number.suffixDeterminater());
    }

    public static string suffixDeterminater(this int number)
    {
        // 1. Check the last two digits for the teen exceptions (11, 12, 13)
        int lastTwoDigits = number % 100;
        if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
        {
            return "th";
        }

        // 2. Fall back to checking the last single digit
        int lastnumber = number % 10;
        if (lastnumber == 1)
        {
            return "st";
        }
        else if (lastnumber == 2)
        {
            return "nd";
        }
        else if (lastnumber == 3)
        {
            return "rd";
        }
        else
        {
            return "th";
        }
    }
}