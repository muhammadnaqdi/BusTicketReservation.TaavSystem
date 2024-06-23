using BusTicketReservation.TaavSystem.Menu;

IRunnable mainMenu = new MainMenu(Console.Write, Console.ReadLine!);
mainMenu.Start();