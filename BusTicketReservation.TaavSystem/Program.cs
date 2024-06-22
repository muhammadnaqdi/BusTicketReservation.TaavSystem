using BusTicketReservation.TaavSystem.Utilities;

MainMenuOption option;
do
{
    MainMenuUtilities.Print(Console.WriteLine);
    Console.Write("Option: ");
    string userInput = Console.ReadLine()!;
    if (MainMenuUtilities.ParseUserInput(userInput, out option))
        MainMenuUtilities.PerformOption(option);
    else
        Console.WriteLine("Invalid input.");
} while (option != MainMenuOption.Exit);