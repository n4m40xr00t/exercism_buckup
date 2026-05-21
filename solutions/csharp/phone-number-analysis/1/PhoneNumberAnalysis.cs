public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneNumberParts = phoneNumber.Split("-");
        bool IsNewYork;
        bool IsFake;
        if ((phoneNumberParts[0] != null) && (phoneNumberParts[0] == "212"))
        {
            IsNewYork = true;
        }
        else
        {
            IsNewYork = false;
        }
        if ((phoneNumberParts[0] != null) && (phoneNumberParts[1] == "555"))
        {
            IsFake = true;
        }
        else
        {
            IsFake = false;
        }
        return (IsNewYork, IsFake, phoneNumberParts[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
