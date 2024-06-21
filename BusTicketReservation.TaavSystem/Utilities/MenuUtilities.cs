namespace BusTicketReservation.TaavSystem.Utilities;

public static class MenuUtilities
{
    public static void MainMenuPrint()
    {
        Console.Write("Main Menu:\n" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.BusDefine}\n" +
                          $"{(int)MainMenuOption.TripDefine}: {MainMenuOption.TripDefine}\n" +
                          $"{(int)MainMenuOption.TripPreview}: {MainMenuOption.TripPreview}\n" +
                          $"{(int)MainMenuOption.TicketReserve}: {MainMenuOption.TicketReserve}\n" +
                          $"{(int)MainMenuOption.TicketPurchase}: {MainMenuOption.TicketPurchase}\n" +
                          $"{(int)MainMenuOption.TicketCancel}: {MainMenuOption.TicketCancel}\n" +
                          $"{(int)MainMenuOption.TripStatics}: {MainMenuOption.TripStatics}\n" +
                          $"{(int)MainMenuOption.Exit}: {MainMenuOption.Exit}\n\n");
    }

    public static MainMenuOption MainMenuParseInput(string userInput)
    {
        int numericOption;
        
        if (!int.TryParse(userInput, out numericOption))
            return MainMenuOption.Invalid;
        
        if (!Enum.IsDefined(typeof(MainMenuOption), numericOption))
            return MainMenuOption.Invalid;
        
        return (MainMenuOption)numericOption;
    }

    public static void MainMenuPerformOption(MainMenuOption option)
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
            case MainMenuOption.Invalid:
            default:
                Console.WriteLine(MainMenuOption.Invalid + Environment.NewLine);
                break;
        }
    }
}