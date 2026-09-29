using System;

namespace InnManager.Reservations
{
    /// <summary>
    /// Represents a reservation made by a guest.
    /// </summary>
    public class Reservation
    {
        public string GuestName { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;
        public DateTime CheckInDate { get; set; } = DateTime.Now;
        public DateTime CheckOutDate { get; set; } = DateTime.Now;
        public bool IsCheckedOut { get; set; } = false;

        /// <summary>
        /// Returns true when the reservation is not checked out and the checkout date is in the past.
        /// </summary>
        public bool IsCheckedOutOverdue => !IsCheckedOut && DateTime.Today > CheckOutDate.Date;

        public bool IsConfirmed { get; set; } = false;

        /// <summary>
        /// True when the reservation has been confirmed and the guest is not checked out yet.
        /// </summary>
        public bool IsActive => IsConfirmed && !IsCheckedOut;

        /// <summary>
        /// Human-friendly reservation status.
        /// </summary>
        public string Status
        {
            get
            {
                if (IsCheckedOut) return "Checked Out";
                if (IsCheckedOutOverdue) return "Overdue";
                if (IsConfirmed) return "Confirmed";
                return "Pending";
            }
        }
    }
}
