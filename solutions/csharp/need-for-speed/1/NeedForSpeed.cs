class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven;
    private int batteryLevel = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained()
    {
        return batteryLevel < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (batteryLevel >= batteryDrain)
        {
            distanceDriven += speed;
            batteryLevel -= batteryDrain;
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
        while (!car.BatteryDrained() && car.DistanceDriven() < distance)
        {
            car.Drive();
        }

        return car.DistanceDriven() >= distance;
    }
}
