class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int battery = 100;
    private int distance;
    
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        bool isDrained;
        if (this.battery < this.batteryDrain){
            isDrained = true;
        } else{
            isDrained = false;
        }
        return isDrained;
    }

    public int DistanceDriven() => this.distance;

    public void Drive()
    {
        if (!this.BatteryDrained()){
            this.distance += this.speed;
            this.battery -= this.batteryDrain;
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
    
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()){
            car.Drive();
        }
        return this.distance <= car.DistanceDriven();
    }
}
