namespace BusTicketReservation.TaavSystem;

public class Seat
{
    private int seatNumber;
    
    public int SeatNumber
    {
        get
        {
            return seatNumber;
        }
        
        set
        {
            if (value > 0)
            {
                seatNumber = value;
            }
        }
    }

    public SeatStatus SeatStatus { get; set; }

    public Seat(int seatNumber, SeatStatus seatStatus) => (SeatNumber, SeatStatus) = (seatNumber, seatStatus);
}