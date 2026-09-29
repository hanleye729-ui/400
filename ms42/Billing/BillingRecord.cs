using System;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents the shared information for a billing record.
    /// </summary>
    public abstract class BillingRecord : IBillingRecord
    {
        /// <summary>
        /// Gets or sets the amount of the billing record.
        /// </summary>
        public decimal Amount { get; set; } = decimal.Zero;

        /// <summary>
        /// Gets or sets the date of the billing record.
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the description of the billing record.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the billing record has been processed.
        /// </summary>
        public bool IsProcessed { get; set; } = false;

        /// <summary>
        /// Gets the signed amount of the billing record.
        /// </summary>
        public abstract decimal SignedAmount { get; }
    }
}
