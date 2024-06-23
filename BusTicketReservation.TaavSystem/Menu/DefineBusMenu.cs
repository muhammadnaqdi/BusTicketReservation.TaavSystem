namespace BusTicketReservation.TaavSystem.Menu;

public class DefineBusMenu(Action<string> writer, Func<string> reader) : IRunnable
{
    public void Start()
    {
        DefineBusMenuOption option;
        PrintMenu();
    }
    
    public void PrintMenu()
    {
        writer.Invoke($"""
                       Define Bus:
                       {(int)DefineBusMenuOption.DefineBus}: {DefineBusMenuOption.DefineBus}
                       {(int)DefineBusMenuOption.DefineVipBus}: {DefineBusMenuOption.DefineVipBus}
                       {(int)DefineBusMenuOption.Exit}: {DefineBusMenuOption.Exit}
                       
                       
                       """);
    }
    
    
}