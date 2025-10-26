class WeighingMachine
{
    public int Precision {get; private set;}
    
    private double weight;
    public double Weight {
        get{ return this.weight; }
        set{
            if (value<0){
                throw new ArgumentOutOfRangeException("Weight can't be negative");
            } else{
                this.weight = value;
            }
        }
    }
    
    public string DisplayWeight {
        get { 
            double res = this.weight - this.TareAdjustment;
            string resPrecised = res.ToString($"F{this.Precision}");
            return $"{resPrecised} kg"; 
        }
    }
    
    public double TareAdjustment {get; set;} = 5;

    public WeighingMachine(int precision){
        this.Precision = precision;
    }
}
