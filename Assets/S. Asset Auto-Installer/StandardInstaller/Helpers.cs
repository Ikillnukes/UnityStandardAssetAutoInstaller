public static class Helpers
{
    #region "String Extensions"
    public static string FirstCharToUpper(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";
        return input[0].ToString().ToUpper() + input.Substring(1);
    }
    public static string ReplaceLast(this string Source, string Find, string Replace)
    {
        int place = Source.LastIndexOf(Find);

        if (place == -1)
            return Source;

        string result = Source.Remove(place, Find.Length).Insert(place, Replace);
        return result;
    }
    #endregion
}