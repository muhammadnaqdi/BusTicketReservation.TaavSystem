namespace BusTicketReservation.TaavSystem;

public class Bus
{
    private static int capacity = 44;
    private static int counter = 1;
    
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