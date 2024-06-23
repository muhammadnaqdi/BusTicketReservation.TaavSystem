namespace BusTicketReservation.TaavSystem.Menu;

public class BusDefineMenu(Action<string> writer, Func<string> reader) : IRunnable
{
    public void Start()
    {
        BusDefineMenuOption option;
        PrintMenu();
        writer.Invoke("Option: ");
        string userInput = reader.Invoke();
        writer(Environment.NewLine);
        if (TryParseUserInput(userInput, out option))
            PerformOption(option);
        else
            writer("Invalid input." + Environment.NewLine);
    }
    
    public void PrintMenu()
    {
        writer.Invoke($"""
                       *** Define Bus ***
                       {(int)BusDefineMenuOption.BusDefine}: {BusDefineMenuOption.BusDefine}
                       {(int)BusDefineMenuOption.VipBusDefine}: {BusDefineMenuOption.VipBusDefine}
                       {(int)BusDefineMenuOption.Exit}: {BusDefineMenuOption.Exit}
                       
                       
                       """);
    }
    
    private bool TryParseUserInput(string userInput, out BusDefineMenuOption result)
    {
        result = BusDefineMenuOption.BusDefine;
        
        if (!int.TryParse(userInput, out int numericOption))
            return false;

        if (!Enum.IsDefined(typeof(BusDefineMenuOption), numericOption))
            return false;
        
        result = (BusDefineMenuOption)numericOption;
        
        return true;
    }

    void PerformOption(BusDefineMenuOption option)
    {
        switch (option)
        {
            case BusDefineMenuOption.BusDefine:
                break;
            case BusDefineMenuOption.VipBusDefine:
                break;
            case BusDefineMenuOption.Exit:
                break;
        }
    }
}