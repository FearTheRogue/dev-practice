public static class ScrabbleScore
{
    private static readonly Dictionary<int, string> Letters = new()
    {
        { 1, "AEIUOLNRST" },
        { 2, "DG" },
        { 3, "BCMP" },
        { 4, "FHVWY" },
        { 5, "K" },
        { 8, "JX" },
        { 10, "QZ" }
    };
    
    public static int Score(string input)
    {
        int score = 0;

        foreach (char c in input.ToUpper())
        {
            foreach (var letter in Letters)
            {
                if (letter.Value.Contains(c))
                {
                    score += letter.Key;
                    break;
                }
            }
        }

        return score;
    }
}