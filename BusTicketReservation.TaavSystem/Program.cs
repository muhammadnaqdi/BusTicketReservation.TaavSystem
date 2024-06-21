using BusTicketReservation.TaavSystem.Utilities;

Console.WriteLine(@"
 /$$$$$$$$ /$$           /$$                   /$$           /$$$$$$$                        
|__  $$__/|__/          | $$                  | $$          | $$__  $$                       
   | $$    /$$  /$$$$$$$| $$   /$$  /$$$$$$  /$$$$$$        | $$  \ $$  /$$$$$$   /$$$$$$$   
   | $$   | $$ /$$_____/| $$  /$$/ /$$__  $$|_  $$_/        | $$$$$$$/ /$$__  $$ /$$_____/   
   | $$   | $$| $$      | $$$$$$/ | $$$$$$$$  | $$          | $$__  $$| $$$$$$$$|  $$$$$$    
   | $$   | $$| $$      | $$_  $$ | $$_____/  | $$ /$$      | $$  \ $$| $$_____/ \____  $$   
   | $$   | $$|  $$$$$$$| $$ \  $$|  $$$$$$$  |  $$$$/      | $$  | $$|  $$$$$$$ /$$$$$$$//$$
   |__/   |__/ \_______/|__/  \__/ \_______/   \___/        |__/  |__/ \_______/|_______/|__/

");

MainMenuOption option;
do
{
    MenuUtilities.MainMenuPrint();
    option = MenuUtilities.MainMenuParseInput(Console.ReadLine()!);
    MenuUtilities.MainMenuPerformOption(option);
} while (option != MainMenuOption.Exit);