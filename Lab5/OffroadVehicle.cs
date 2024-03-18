namespace Lab5;

public class OffroadVehicle : Transport
{
    public double GroundClearance { get; set; }
    public bool IsFourWheelDrive { get; set; }
    public string TerrainType { get; set; }

    public OffroadVehicle(BaseInform baseInfo, double groundClearance, bool isFourWheelDrive, string terrainType) : base(baseInfo)
    {
        GroundClearance = groundClearance;
        IsFourWheelDrive = isFourWheelDrive;
        TerrainType = terrainType;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Ground Clearance: {GroundClearance} cm, 4WD: {IsFourWheelDrive}, Terrain: {TerrainType}";
    }
}
