namespace BusTicketReservation.TaavSystem.Utilities;

public static class MainMenuUtilities
{
    public static void Print(Action<string> writer)
    {
        writer.Invoke($"""
                       Main Menu:
                       {(int)MainMenuOption.BusDefine}: {MainMenuOption.BusDefine}
                       {(int)MainMenuOption.TripDefine}: {MainMenuOption.TripDefine}
                       {(int)MainMenuOption.TripPreview}: {MainMenuOption.TripPreview}
                       {(int)MainMenuOption.TicketReserve}: {MainMenuOption.TicketReserve}
                       {(int)MainMenuOption.TicketPurchase}: {MainMenuOption.TicketPurchase}
                       {(int)MainMenuOption.TicketCancel}: {MainMenuOption.TicketCancel}
                       {(int)MainMenuOption.TripStatics}: {MainMenuOption.TripStatics}
                       {(int)MainMenuOption.Exit}: {MainMenuOption.Exit}

                       """);
    }

    public static bool ParseUserInput(string userInput, out MainMenuOption result)
    {
        result = MainMenuOption.BusDefine;
        
        if (!int.TryParse(userInput, out int numericOption))
            return false;

        if (!Enum.IsDefined(typeof(MainMenuOption), numericOption))
            return false;
        
        result = (MainMenuOption)numericOption;
        
        return true;
    }

    public static void PerformOption(MainMenuOption option)
    {
        switch (option)
        {
            case MainMenuOption.BusDefine:
                Console.WriteLine(MainMenuOption.BusDefine + Environment.NewLine);
                break;
            case MainMenuOption.TripDefine:
                Console.WriteLine(MainMenuOption.TripDefine + Environment.NewLine);
                break;
            case MainMenuOption.TripPreview:
                Console.WriteLine(MainMenuOption.TripPreview + Environment.NewLine);
                break;
            case MainMenuOption.TicketReserve:
                Console.WriteLine(MainMenuOption.TicketReserve + Environment.NewLine);
                break;
            case MainMenuOption.TicketPurchase:
                Console.WriteLine(MainMenuOption.TicketPurchase + Environment.NewLine);
                break;
            case MainMenuOption.TicketCancel:
                Console.WriteLine(MainMenuOption.TicketCancel + Environment.NewLine);
                break;
            case MainMenuOption.TripStatics:
                Console.WriteLine(MainMenuOption.TripStatics + Environment.NewLine);
                break;
            case MainMenuOption.Exit:
                Console.WriteLine(MainMenuOption.Exit);
                break;
        }
    }
}