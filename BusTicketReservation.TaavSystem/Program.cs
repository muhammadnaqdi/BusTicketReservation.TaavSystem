using BusTicketReservation.TaavSystem.Utilities;

MainMenuOption option;
do
{
    MainMenuUtilities.PrintMenu(Console.WriteLine);
    Console.Write("Option: ");
    string userInput = Console.ReadLine()!;
    if (MainMenuUtilities.TryParseUserInput(userInput, out option))
        MainMenuUtilities.PerformOption(option);
    else
        Console.WriteLine("Invalid input.");
} while (option != MainMenuOption.Exit);