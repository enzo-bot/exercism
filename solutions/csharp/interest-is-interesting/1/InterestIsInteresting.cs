static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interest;
        switch (balance){
            case < 0:
                interest = 3.213f;
                break;
            case < 1000:
                interest = 0.5f;
                break;
            case < 5000:
                interest = 1.621f;
                break;
            default:
                interest = 2.475f;
                break;
        }
        return interest;
    }

    public static decimal Interest(decimal balance) => (decimal)(InterestRate(balance) / 100) * balance;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        if (balance > 0){
            while (balance < targetBalance){
                balance = AnnualBalanceUpdate(balance);
                years ++;
            }
        }
        return years;
    }
}
