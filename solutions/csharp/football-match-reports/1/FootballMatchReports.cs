public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
                return "center back";
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
                return "midfielder";
            case 7:
                return "midfielder";
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int number:
                return String.Format("There are {0} supporters at the match.", number);
            case string str:
                return str;
            case Foul FoulObject:
                return FoulObject.GetDescription();
            case Injury InjuryObject:
                return String.Format("Oh no! {0} Medics are on the field.", InjuryObject.GetDescription());
            case Incident IncidentObject:
                return IncidentObject.GetDescription();
            case Manager ManagerObject when ManagerObject.Club == null:
                return ManagerObject.Name;
            case Manager ManagerObject:
                return String.Format("{0} ({1})", ManagerObject.Name, ManagerObject.Club);
            default:
                return "";
        }
    }
}
