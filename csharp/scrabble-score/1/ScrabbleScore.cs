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
            
            if (str == "A" || str == "E" || str == "I" || str == "O" || str == "U" || str == "L" || str == "N" || str == "R" || str == "S" || str == "T")
            {
                score += 1;
            }
            else if (str == "D" || str == "G")
            {
                score += 2;
            }
            else if (str == "B" || str == "C" || str == "M" || str == "P")
            {
                score += 3;
            }
            else if (str == "F" || str == "H" || str == "V" || str == "W" || str == "Y")
            {
                score += 4;
            }
            else if (str == "K")
            {
                score += 5;
            }
            else if (str == "J" || str == "X")
            {
                score += 8;
            }
            else 
            {
                score += 10;
            }
        }

        return score;
    }
}