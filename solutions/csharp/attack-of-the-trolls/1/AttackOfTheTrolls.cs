[Flags]
public enum AccountType
{
    Guest = 1 << 0, // 1 (0b0001)
    User = 1 << 1, // 2 (0b0010)
    Moderator = 1 << 2, // 4 (0b0100)
}


[Flags]
public enum Permission
{
    None = 0,
    Read = 1 << 0, // 1 (0b0001)
    Write = 1 << 1, // 2 (0b0010)
    Delete = 1 << 2, // 4 (0b0100)
    All = Read | Write | Delete
}
static class Permissions
{
    public static Permission Default(AccountType accountType)
    {
        switch (accountType)
        {
            case AccountType.Guest:
                return Permission.Read;
            case AccountType.User:
                return Permission.Read | Permission.Write;
            case AccountType.Moderator:
                return Permission.All;
            default:
                return Permission.None;
        }
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        return current.HasFlag(check);
    }
}
