using System;

namespace InnManager.Housekeeping
{
    /// <summary>
    /// Represents a housekeeping task for a specific room.
    /// </summary>
    public class HouseKeepingTask
    {
        public string RoomNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ScheduledDate { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; } = false;

        /// <summary>
        /// Derived status of the task.
        /// </summary>
        public string Status => IsCompleted ? "Completed" : "Not Completed";
    }
}
