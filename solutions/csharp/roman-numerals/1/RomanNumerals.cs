using System.Net.Http.Headers;

public static class RomanNumeralExtension
{
    public static char toOneRoman(this int number)
    {
        if (number == 1000)
        {
            return 'M';
        } else if (number == 500)
        {
            return 'D';
        } else if (number == 100)
        {
            return 'C';
        } else if (number == 50)
        {
            return 'L';
        } else if (number == 10)
        {
            return 'X';
        } else if (number == 5)
        {
            return 'V';
        } else if (number == 1)
        {
            return 'I';
        } else
        {
            return 'J';
        }
    }
    public static string ToRoman(this int value)
    {
        string numberStr = value.ToString();
        int[] numbers = new int[numberStr.Length];

        string romanNumber = "";

        for (int i = 0; i < numberStr.Length; i++)
        {
            numbers[i] = int.Parse(numberStr[i].ToString());
        }

        int pos = 0;
        while (numbers.Length > pos)
        {
            if (numbers[pos] <= 3)
            {
                romanNumber += new string(int.Parse("1" + new string('0', numbers.Length - pos - 1)).toOneRoman(), numbers[pos]);
            } else if (numbers[pos] == 4)
            {
                romanNumber += int.Parse("1" + new string('0', numbers.Length - pos - 1)).toOneRoman().ToString() + int.Parse("5" + new string('0', numbers.Length - pos - 1)).toOneRoman().ToString();
            } else if (numbers[pos] == 5)
            {
                romanNumber += int.Parse("5" + new string('0', numbers.Length - pos - 1)).toOneRoman();

            } else if ((numbers[pos] >= 6) && (numbers[pos] < 9))
            {
                romanNumber += int.Parse("5" + new string('0', numbers.Length - pos - 1)).toOneRoman().ToString() + new string(int.Parse("1" + new string('0', numbers.Length - pos - 1)).toOneRoman(), numbers[pos] - 5).ToString();

            } else if (numbers[pos] == 9)
            {
                romanNumber += int.Parse("1" + new string('0', numbers.Length - pos - 1)).toOneRoman().ToString() + int.Parse("1" + new string('0', numbers.Length - pos)).toOneRoman().ToString();
            }
            pos++;
        }
        return romanNumber;
    }
}