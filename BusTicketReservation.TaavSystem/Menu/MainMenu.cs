namespace BusTicketReservation.TaavSystem.Menu;

public class MainMenu(Action<string> writer, Func<string> reader) : IRunnable
{
    public void Start()
    {
        MainMenuOption option;
        do
        {
            PrintMenu();
            writer("Option: ");
            string userInput = reader.Invoke();
            writer(Environment.NewLine);
            if (TryParseUserInput(userInput, out option))
                PerformOption(option);
            else
                writer("Invalid input." + Environment.NewLine);
        } while (option != MainMenuOption.Exit);
    }

    private void PrintMenu()
    {
        writer.Invoke($"""
                       *** Main Menu ***
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

    private bool TryParseUserInput(string userInput, out MainMenuOption result)
    {
        result = MainMenuOption.BusDefine;
        
        if (!int.TryParse(userInput, out int numericOption))
            return false;

        if (!Enum.IsDefined(typeof(MainMenuOption), numericOption))
            return false;
        
        result = (MainMenuOption)numericOption;
        
        return true;
    }

    private void PerformOption(MainMenuOption option)
    {
        switch (option)
        {
            case MainMenuOption.BusDefine:
                IRunnable busDefineMenu = new BusDefineMenu(writer, reader);
                busDefineMenu.Start();
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