public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        string name;
        if (!(shirtNum < 1 || shirtNum > 11)){
            switch (shirtNum){
                case 1:
                    name = "goalie";
                    break;
                case 2:
                    name = "left back";
                    break;
                case 3:
                    name = "center back";
                    break;
                case 4:
                    name = "center back";
                    break;
                case 5:
                    name = "right back";
                    break;
                case 9:
                    name = "left wing";
                    break;
                case 10:
                    name = "striker";
                    break;
                case 11:
                    name = "right wing";
                    break;
                default:
                    name = "midfielder";
                    break;
            }
        } else{
            name = "UNKNOWN";
        }
        return name;
    }

    public static string AnalyzeOffField(object report)
    {
        string res;
        switch (report){
            case int supporterNb:
                res = $"There are {supporterNb} supporters at the match.";
                break;
            case string announcement:
                res = announcement;
                break;
            case Foul foul:
                res = foul.GetDescription();
                break;
            case Injury injury:
                string player = injury.GetDescription().Substring(7,2).Trim();
                res = $"Oh no! Player {player} is injured. Medics are on the field.";
                break;
            case Incident incident:
                res = incident.GetDescription();
                break;
            case Manager manager when manager.Club == null:
                res = manager.Name;
                break;
            case Manager manager:
                res = $"{manager.Name} ({manager.Club})";
                break; 
            default:
                res = "";
                break;
        }
        
        return res;
    }
}
