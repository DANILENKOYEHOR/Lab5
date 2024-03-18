using Lab5;

internal class Program
{
    public static void Main(string[] args)
    {
        
        TransportManager manager = new TransportManager();

        
        BaseInform infoCar = new BaseInform("Car", "Tesla", 2021, "Electric", 250);
        Transport car = new PassengerCar(infoCar, 5, "Model S", 500);

        BaseInform infoTruck = new BaseInform("Truck", "Volvo", 2019, "Diesel", 180);
        Transport truck = new Truck(infoTruck, 10, "Cargo", true);

        BaseInform infoOffroad = new BaseInform("Offroad", "Jeep", 2022, "Gasoline", 200);
        Transport offroad = new OffroadVehicle(infoOffroad, 22, true, "All-Terrain");

        // добавление транспорта
        manager.AddTransport(car);
        manager.AddTransport(truck);
        manager.AddTransport(offroad);

        // вывод всего списка
        Console.WriteLine("Initial transport list:");
        manager.DisplayAllTransports();

        // редактирование
        BaseInform infoEditCar = new BaseInform("Edited Car", "Tesla", 2022, "Electric", 260);
        PassengerCar editedCar = new PassengerCar(infoEditCar, 5, "Model X", 550);
        manager.EditTransport(0, editedCar); // Предполагается, что car находится на позиции 0

        // после редактирования
        Console.WriteLine("\nTransport list after editing:");
        manager.DisplayAllTransports();

        // удаление
        manager.RemoveTransport(truck);

        // после удаления
        Console.WriteLine("\nTransport list after removal:");
        manager.DisplayAllTransports();
    }
    
}