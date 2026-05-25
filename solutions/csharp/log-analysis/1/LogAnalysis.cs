public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string spliter)
    {
        int spliterPos = str.IndexOf(spliter);
        string mainString = str.Substring(spliterPos + spliter.Length);

        return mainString;
    }

    public static string SubstringBetween(this string str, string firstText, string lastText)
    {
        int firstLetterPos = str.IndexOf(firstText);
        int lastLetterPos = str.IndexOf(lastText);

        int startIndex = firstLetterPos + firstText.Length;

        int length = lastLetterPos - startIndex;

        string strBetween = str.Substring(startIndex, length).Trim();
        return strBetween;
    }

    public static string Message(this string str)
    {
        int spliterPos = str.IndexOf(":");

        return str.Substring(spliterPos + 2);
    }

    public static string LogLevel(this string str)
    {
        int firstLetterPos = str.IndexOf("[");
        int lastLetterPos = str.IndexOf("]");

        string Level = str.Substring(firstLetterPos + 1, lastLetterPos - 1);
        return Level;
    }
}