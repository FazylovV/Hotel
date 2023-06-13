using System;
using System.Collections.Generic;
using Hotel.Exceptions;

namespace Hotel.Models;

public class ReservationBook
{
    private readonly List<Reservation> _reservations;

    public ReservationBook()
    {
        _reservations = new List<Reservation>();
    }

    public List<Reservation> GetAllReservations()
    {
        return _reservations;
    }

    public void AddReservation(Reservation reservation)
    {
        foreach (var existingReservation in _reservations)
        {
            if (existingReservation.Conflicts(reservation))
            {
                throw new ReservationConflictException(existingReservation, reservation);
            }
        }
        
        _reservations.Add(reservation);
    }
}