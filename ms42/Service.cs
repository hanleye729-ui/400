using System;
using InnManager.Enums;

namespace InnManager.Services
{
    /// <summary>
    /// Represents a service offered by the hotel.
    /// </summary>
    public class Service
    {
        public string ServiceName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// Category of the service.
        /// </summary>
        public ServiceCategory Category { get; set; } = ServiceCategory.Miscellaneous;
    }
}
