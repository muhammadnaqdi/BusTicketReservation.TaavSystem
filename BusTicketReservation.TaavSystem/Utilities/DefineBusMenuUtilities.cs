namespace BusTicketReservation.TaavSystem.Utilities;

public class DefineBusMenuUtilities
{
    public void PrintMenu(Action<string> writer)
    {
        writer.Invoke($"""
                       Define Bus:
                       {(int)DefineBusMenuOption.DefineBus}: {DefineBusMenuOption.DefineBus}
                       {(int)DefineBusMenuOption.DefineVipBus}: {DefineBusMenuOption.DefineVipBus}
                       {(int)DefineBusMenuOption.Exit}: {DefineBusMenuOption.Exit} 
                       """);
    }
    
    
}