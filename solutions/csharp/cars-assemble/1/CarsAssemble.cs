static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double success = 0;
        if ((speed >= 1) && (speed <= 4)){
            success = 1;
        } else if ((speed >= 5) && (speed <= 8)){
            success = 0.90;
        } else if (speed == 9) {
            success = 0.80;
        } else if (speed == 10) {
            success = 0.77;
        }
        return success;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
