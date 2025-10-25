static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string res;
        if (id == null && department == null){
            res = $"{name} - OWNER";
        } else if (id == null && department != null){
            res = $"{name} - {department.ToUpper()}";
        } else if (id != null && department == null){
            res = $"[{id}] - {name} - OWNER";
        } else{
            res = $"[{id}] - {name} - {department.ToUpper()}";
        }
        return res;
    }
}
