using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:  return "goalie";
            case 2:  return "left back";
            case 4:
            case 3: return "center back";
            case 5: return "right back";
            case 7:
            case 8:
            case 6: return "midfielder";
            case 9: return "left wing";
            case 10: return "striker";
            case 11: return "right wing";
            default: throw new ArgumentOutOfRangeException();
        }
    }

    public static string AnalyzeOffField(object report)
    {
        string output = string.Empty;

        switch (report)
        {
            case int:
                {
                    int integer = Convert.ToInt32(report.ToString());
                    output = $"There are {integer} supporters at the match.";
                    break;
                }

            case string:
                output = report.ToString();
                break;

            case Foul:
                Foul foul = (Foul)report;
                output = foul.GetDescription();
                break;

            case Injury:
                Injury injury = (Injury)report;
                output = "Oh no! " + injury.GetDescription() + " Medics are on the field.";
                break;

            case Incident:
                Incident incident = (Incident)report;
                output = incident.GetDescription();
                break;

            case Manager:
                Manager manager = (Manager)report;
                output = GetDescription(manager);
                break;

            default:
                throw new ArgumentException();
        }

        return output;

    }

    public static string GetDescription(Manager manager)
    {
        string description = string.Empty;
        description += manager.Name;

        if (manager.Club != null)
        {
            description += " (" + manager.Club + ")";
        }

        return description;
    }
}
