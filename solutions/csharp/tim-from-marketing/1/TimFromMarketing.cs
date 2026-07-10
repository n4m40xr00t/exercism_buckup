static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null)
        {
            return String.Format("{0} - {1}", name, department?.ToUpper() ?? "OWNER");
        }
        else
        {
            return String.Format("[{0}] - {1} - {2}", id, name, department?.ToUpper() ?? "OWNER");
        }

    }
}
