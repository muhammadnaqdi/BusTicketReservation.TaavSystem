using BusTicketReservation.TaavSystem.Utilities;

MainMenuOption option;
do
{
    MenuUtilities.MainMenuPrint();
    option = MenuUtilities.MainMenuParseInput(Console.ReadLine()!);
    MenuUtilities.MainMenuPerformOption(option);
} while (option != MainMenuOption.Exit);