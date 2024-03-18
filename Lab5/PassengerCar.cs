namespace Lab5;

public class PassengerCar : Transport
{
    public int Seats { get; set; }
    public string Model { get; set; }
    public double TrunkCapacity { get; set; }

    public PassengerCar(BaseInform baseInfo, int seats, string model, double trunkCapacity) : base(baseInfo)
    {
        Seats = seats;
        Model = model;
        TrunkCapacity = trunkCapacity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Seats: {Seats}, Model: {Model}, Trunk Capacity: {TrunkCapacity} L";
    }
}
