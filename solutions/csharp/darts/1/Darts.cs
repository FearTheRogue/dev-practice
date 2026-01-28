public static class Darts
{
    public static int Score(double x, double y)
    {
        double squaredDistance = x * x + y * y;

        if (squaredDistance <= 1)
            return 10;
        else if (squaredDistance <= 25)
            return 5;
        else if (squaredDistance <= 100)
            return 1;
        else
            return 0;
    }
}
