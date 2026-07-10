using System;

class RemoteControlCar
{
    public int BatteryOfCar;
    public int speed;
    public int batteryDrain;
    private int DrivenDistance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.BatteryOfCar = 100;
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.DrivenDistance = 0;
    }

    public bool BatteryDrained()
    {
        return this.BatteryOfCar < this.batteryDrain;
    }

    public int DistanceDriven()
    {
        return DrivenDistance;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.DrivenDistance += this.speed;
            this.BatteryOfCar -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        if ((((car.BatteryOfCar - (car.BatteryOfCar % car.batteryDrain)) / car.batteryDrain) * car.speed) >= this.distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}