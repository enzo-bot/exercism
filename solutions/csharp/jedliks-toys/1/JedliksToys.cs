class RemoteControlCar
{
    private int distance;
    private int battery = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {this.distance} meters";

    public string BatteryDisplay(){
        string res;
        if (this.battery < 1){
            res = $"Battery empty";
        } else{
            res = $"Battery at {this.battery}%";
        }
        return res;
    } 

    public void Drive()
    {
        if (this.battery > 0){
            this.distance += 20;
            this.battery -= 1;
        }
        
    }
}
