public static class ScrabbleScore
{
    public static int Score(string input)
    {
        string upperString = input.ToUpper();   
        char[] characters = upperString.ToCharArray();
        int score = 0;

        foreach (char c in characters)
        {
            string str = c.ToString();
            
            if ("AEIOULNRST".Contains(c))
                score += 1;
            else if ("DG".Contains(c))
                score += 2;
            else if ("BCMP".Contains(c))
                score += 3;
            else if ("FHVWY".Contains(c))
                score += 4;
            else if ("K".Contains(c))
                score += 5;
            else if ("JX".Contains(c))
                score += 8;
            else 
                score += 10;
        }

        return score;
    }
}