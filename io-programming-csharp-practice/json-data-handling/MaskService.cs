class MaskService
{
    public static string MaskTeam(string team)
    {
        var p = team.Split(' ');
        if (p.Length > 1) p[1] = "***";
        return string.Join(" ", p);
    }
}
