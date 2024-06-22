namespace BusTicketReservation.TaavSystem;

public class VipBus : IReservable
{
    private static int counter = 1;
    private static int capacity = 30;
    
    public int Id { get; } = counter++;

    public List<Seat> GetSeats()
    {
        List<Seat> seats = new List<Seat>();

        for (int i = 1; i <= capacity; ++i)
        {
            seats.Add(new Seat(i, SeatStatus.Free));
        }

        return seats;
    }
}