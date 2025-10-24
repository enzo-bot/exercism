class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int elapsedTime) => this.ExpectedMinutesInOven() - elapsedTime;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layersNb) => layersNb*2;
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersNb, int elapsedTime) => layersNb*2 + elapsedTime;
}
