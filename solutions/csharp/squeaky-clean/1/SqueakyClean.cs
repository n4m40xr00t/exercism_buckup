public static class Identifier
{
    public static string Clean(string identifier)
    {
        String CleanBuilder = "";
        bool IsKebabCasePrev = false;
        bool IsLetterORDigit = false;
        char GreekFirstLetter = 'α';
        char GreekLastLetter = 'ω';

        foreach (char c in identifier)
        {
            char ModifiedChar = c;
            if (IsKebabCasePrev)
            {
                ModifiedChar = Char.ToUpper(c);
                IsKebabCasePrev = false;
            }

            if (c == ' ')
            {
                CleanBuilder += "_";
            }
            else if (Char.IsControl(c))
            {
                CleanBuilder += "CTRL";
            }
            else if (c == '-')
            {
                IsKebabCasePrev = true;
            }
            else if (c >= 'α' && c <= 'ω')
            {
                continue;
            }
            else if (Char.IsLetter(c))
            {
                CleanBuilder += ModifiedChar;
            }
        }
        return CleanBuilder;

    }
}