class RemoteControlCar
{
    private int _drivenMeters;
    private int _battery = 100; 
    // 1 percent = 20 meters
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
            return String.Format("Driven {0} meters", _drivenMeters);
    }

    public string BatteryDisplay()
    {
        if (_battery > 0)
        {
            return String.Format("Battery at {0}%", _battery);
        }
        else
        {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if (_battery > 0)
        {
            _drivenMeters += 20;
            _battery--;
        }
    }
}
