namespace BusTicketReservation.TaavSystem;

public class Seat
{
    private int _seatNumber;
    
    public int SeatNumber
    {
        get => _seatNumber;

        set
        {
            if (value > 0)
            {
                _seatNumber = value;
            }
        }
    }

    public SeatStatus SeatStatus { get; set; }

    public Seat(int seatNumber, SeatStatus seatStatus) => (SeatNumber, SeatStatus) = (seatNumber, seatStatus);
}