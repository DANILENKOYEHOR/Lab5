namespace Lab5;

public class Truck : Transport
{
    public double LoadCapacity { get; set; }
    public string CargoType { get; set; }
    public bool HasRefrigerator { get; set; }

    public Truck(BaseInform baseInfo, double loadCapacity, string cargoType, bool hasRefrigerator) : base(baseInfo)
    {
        LoadCapacity = loadCapacity;
        CargoType = cargoType;
        HasRefrigerator = hasRefrigerator;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Load Capacity: {LoadCapacity} tons, Cargo Type: {CargoType}, Refrigerator: {HasRefrigerator}";
    }
}
