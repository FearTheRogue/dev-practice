static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0.0m)
              return 3.213f;
        else if (balance < 1000.0m)
            return 0.5f;
        else if (balance < 5000.0m)
            return 1.621f;
        else
            return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * ((decimal)InterestRate(balance) / 100m);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        if(balance >= targetBalance)
            return 0;
        
        int numYears = 0;
        
        do
        {
            balance += Interest(balance);
            numYears++;
        }
        while (balance <= targetBalance);

        return numYears;
    }
}
