static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double res = 0; 
        if (speed == 0){
            res = 0;
        } else if (speed >= 1 && speed <= 4){
            res = 1;
        } else if (speed >= 5 && speed <= 8){
            res = 0.9;
        } else if (speed == 9){
            res = 0.8;
        } else if (speed == 10){
            res = 0.77;
        }
        return res;
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
