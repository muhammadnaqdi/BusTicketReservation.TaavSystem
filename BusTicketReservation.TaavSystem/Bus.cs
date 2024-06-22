namespace BusTicketReservation.TaavSystem;

public class Bus
{
    private static int _counter = 1;
    private const int Capacity = 44;
    
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