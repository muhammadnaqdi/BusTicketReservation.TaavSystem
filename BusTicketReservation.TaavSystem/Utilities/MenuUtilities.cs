namespace BusTicketReservation.TaavSystem.Utilities;

public static class MenuUtilities
{
    public static void MainMenuPrint()
    {
        Console.WriteLine("Main Menu:\n" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.BusDefine}" +
                          $"{(int)MainMenuOption.TripDefine}: {MainMenuOption.TripDefine}" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.TripPreview}" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.TicketReserve}" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.TicketPurchase}" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.TicketCancel}" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.TripStatics}" +
                          $"{(int)MainMenuOption.BusDefine}: {MainMenuOption.Exit}");
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
                Console.WriteLine(MainMenuOption.BusDefine);
                break;
            case MainMenuOption.TripDefine:
                Console.WriteLine(MainMenuOption.TripDefine);
                break;
            case MainMenuOption.TripPreview:
                Console.WriteLine(MainMenuOption.TripPreview);
                break;
            case MainMenuOption.TicketReserve:
                Console.WriteLine(MainMenuOption.TicketReserve);
                break;
            case MainMenuOption.TicketPurchase:
                Console.WriteLine(MainMenuOption.TicketPurchase);
                break;
            case MainMenuOption.TicketCancel:
                Console.WriteLine(MainMenuOption.TicketCancel);
                break;
            case MainMenuOption.TripStatics:
                Console.WriteLine(MainMenuOption.TripStatics);
                break;
            case MainMenuOption.Exit:
                Console.WriteLine(MainMenuOption.Exit);
                break;
            case MainMenuOption.Invalid:
            default:
                Console.WriteLine(MainMenuOption.Invalid);
                break;
        }
    }
}