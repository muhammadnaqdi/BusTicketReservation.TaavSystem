namespace BusTicketReservation.TaavSystem;

public class VipBus : IReservable
{
    private static int _counter = 1;
    private const int Capacity = 30;
    
    public int Id { get; } = _counter++;

    public List<Seat> GetSeats()
    {
        List<Seat> seats = new List<Seat>();

        for (int i = 1; i <= Capacity; ++i)
        {
            seats.Add(new Seat(i, SeatStatus.Free));
        }

        return seats;
    }
}