using BusTicketReservation.TaavSystem.Utilities;

MainMenuOption option;
do
{
    MenuUtilities.MainMenuPrint();
    Console.Write("Option: ");
    string userInput = Console.ReadLine()!;
    option = MenuUtilities.MainMenuParseInput(userInput);
    MenuUtilities.MainMenuPerformOption(option);
} while (option != MainMenuOption.Exit);