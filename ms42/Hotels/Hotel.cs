using System.Collections.Generic;
using System.Linq;
using InnManager.Enums;
using InnManager.Rooms;
using InnManager.Guests;
using InnManager.Reservations;
using InnManager.Services;
using InnManager.Billing;
using InnManager.Employees;
using InnManager.Housekeeping;

namespace InnManager.Hotels
{
    /// <summary>
    /// Represents a hotel managed by InnManager.
    /// comments written by github copilot
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// Hotel name. Must be provided during object initialization.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Hotel type. Must be provided during object initialization.
        /// </summary>
        public HotelType Type { get; init; }

        /// <summary>
        /// Rooms managed by the hotel.
        /// </summary>
        public List<Room> Rooms { get; } = new List<Room>();

        /// <summary>
        /// Registered guests.
        /// </summary>
        public List<Guest> Guests { get; } = new List<Guest>();

        /// <summary>
        /// Reservations for the hotel.
        /// </summary>
        public List<Reservation> Reservations { get; } = new List<Reservation>();

        /// <summary>
        /// Services offered by the hotel.
        /// </summary>
        public List<Service> Services { get; } = new List<Service>();

        /// <summary>
        /// Invoices issued by the hotel.
        /// </summary>
        public List<Invoice> Invoices { get; } = new List<Invoice>();

        /// <summary>
        /// Payments received by the hotel.
        /// </summary>
        public List<Payment> Payments { get; } = new List<Payment>();

        /// <summary>
        /// Employees working at the hotel.
        /// </summary>
        public List<Employee> Employees { get; } = new List<Employee>();

        /// <summary>
        /// Housekeeping tasks scheduled for the hotel.
        /// </summary>
        public List<HouseKeepingTask> HousekeepingTasks { get; } = new List<HouseKeepingTask>();

        /// <summary>
        /// Number of rooms with status Available.
        /// </summary>
        public int AvailableRoomCount => Rooms.Count(r => r.Status == RoomStatus.Available);

        /// <summary>
        /// Number of rooms with status Occupied.
        /// </summary>
        public int OccupiedRoomCount => Rooms.Count(r => r.Status == RoomStatus.Occupied);
    }
}
