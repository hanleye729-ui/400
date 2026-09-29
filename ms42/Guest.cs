using System;

namespace InnManager.Guests
{
    /// <summary>
    /// Represents a guest staying at the hotel.
    /// </summary>
    public class Guest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public bool IsCheckedIn { get; set; } = false;
    }
}
