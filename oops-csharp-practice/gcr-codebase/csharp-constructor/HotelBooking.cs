class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelBooking(HotelBooking booking)
    {
        guestName = booking.guestName;
        roomType = booking.roomType;
        nights = booking.nights;
    }
}
