namespace TMPS2;
// Facade class that simplifies the maintenance process.

public class VehicleMaintenanceFacade
{
    private EngineCheck _engineCheck;
    private OilChange _oilChange;
    private VehicleWash _vehicleWash;

    public VehicleMaintenanceFacade()
    {
        _engineCheck = new EngineCheck();
        _oilChange = new OilChange();
        _vehicleWash = new VehicleWash();
    }

    public void PerformMaintenance()
    {
        _engineCheck.Check();
        _oilChange.Change();
        _vehicleWash.Wash();
        
        Console.WriteLine("All maintenance tasks completed");
    }
}