static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0){
            return 3.213f;
        }
        else if(balance < 1000){
            return 0.5f;
        }
        else if(balance < 5000){
            return 1.621f;
        }
        else{
            return 2.475f;
        }
        
        
    }

    public static decimal Interest(decimal balance)
{
    if (balance < 0)
        return balance * 3.213m / 100m;
    else if (balance < 1000)
        return balance * 0.5m / 100m;
    else if (balance < 5000)
        return balance * 1.621m / 100m;
    else
        return balance * 2.475m / 100m;
}

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
    while (balance < targetBalance)
    {
        balance =  AnnualBalanceUpdate(balance);
        years++;
    }
    return years;
    }
}
