using System;

namespace Hotel.Models;

public class Reservation
{
    public RoomID RoomID { get; }
    public string Username { get; }
    public DateTime StartTime { get; }
    public DateTime EndTime { get; }

    public TimeSpan Length => EndTime.Subtract(StartTime);

    public Reservation(RoomID roomId, string username, DateTime startTime, DateTime endTime)
    {
        RoomID = roomId;
        Username = username;
        StartTime = startTime;
        EndTime = endTime;
    }

    public bool Conflicts(Reservation reservation)
    {
        if (RoomID != reservation.RoomID)
        {
            return false;
        }

        return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
    }
}