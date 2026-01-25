public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int indexStart = str.IndexOf(delimiter);

        if (indexStart == -1)
            return "";
        
        return str.Substring(indexStart + delimiter.Length);
    }

    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        int startIndex = str.IndexOf(startDelimiter);
        int endIndex = str.IndexOf(endDelimiter);

        if (startIndex == -1 || endIndex == -1 || endIndex <= startIndex)
            return "";
            
        startIndex += startDelimiter.Length;
        int length = endIndex - startIndex;
        
        return str.Substring(startIndex, length);
    }

    public static string Message(this string log) => log.SubstringAfter(": ").Trim();

    public static string LogLevel(this string log) => log.SubstringBetween("[", "]");
}