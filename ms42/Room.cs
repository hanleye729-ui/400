using System;
using InnManager.Enums;

namespace InnManager.Rooms
{
    /// <summary>
    /// Represents a hotel room managed by the InnManager system.
    /// comments written by github copilot
    /// </summary>
    /// <remarks>
    /// The Room class stores identifying information about a hotel room, including its room number, room type, nightly rate and current availability.
    /// </remarks>
    public class Room
    {
        private static long _nextID = 0;

        public static long NextID
        {
            get
            {
                _nextID++;          // Step 1: increment the ID
                return _nextID;     // Step 2: return the new value
            }
        }

        public long RoomID { get; }

        /// <summary>
        /// Human-readable room identifier (e.g. "101").
        /// </summary>
        public string RoomNumber { get; set; } = string.Empty;

        /// <summary>
        /// The type of room.
        /// </summary>
        public RoomType RoomType { get; set; } = RoomType.Standard;
        public bool IsAvailable { get; set; } = true;

        public int Floor { get; set; } = 0;
        public int Capacity { get; set; } = 1;
        public bool HasBalcony { get; set; } = false;
        public bool IsClean { get; set; } = true;

        /// <summary>
        /// Current room status.
        /// </summary>
        public RoomStatus Status { get; set; } = RoomStatus.Available;

        public decimal NightlyRate { get; set; } = 0m;

        public Room()
        {
            RoomID = NextID;
        }

        /// <summary>
        /// Create a new Room with identifying data.
        /// </summary>
        /// <param name="roomNumber">The room number.</param>
        /// <param name="roomType">The type of the room.</param>
        /// <param name="nightlyRate">Nightly rate for the room.</param>
        public Room(string roomNumber, RoomType roomType, decimal nightlyRate) : this()
        {
            RoomNumber = roomNumber ?? string.Empty;
            RoomType = roomType;
            NightlyRate = nightlyRate;
        }
    }
}
