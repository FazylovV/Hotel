using System.Collections.Generic;

namespace Hotel.Models;

public class Hotel
{
    public readonly ReservationBook _reservationBook;
    
    public string Name { get; }

    public Hotel(string name)
    {
        Name = name;
        
        _reservationBook = new ReservationBook();
    }

    public List<Reservation> GetAllReservations()
    {
        return _reservationBook.GetAllReservations();
    }

    public void MakeReservation(Reservation reservation)
    {
        _reservationBook.AddReservation(reservation);
    }
}