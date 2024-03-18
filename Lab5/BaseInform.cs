namespace Lab5;

public class BaseInform
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public string EngineType { get; set; }
    public double MaxSpeed { get; set; }

    public BaseInform(string name, string manufacturer, int year, string engineType, double maxSpeed)
    {
        Name = name;
        Manufacturer = manufacturer;
        Year = year;
        EngineType = engineType;
        MaxSpeed = maxSpeed;
    }

    public override string ToString()
    {
        return $"{Name} by {Manufacturer}, Year: {Year}, Engine: {EngineType}, Max Speed: {MaxSpeed} km/h";
    }
}
