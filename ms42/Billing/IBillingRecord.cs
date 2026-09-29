using System;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents the minimum information required for a billing record.
    /// </summary>
    public interface IBillingRecord
    {
        /// <summary>
        /// Gets the amount of the billing record.
        /// </summary>
        decimal Amount { get; }

        /// <summary>
        /// Gets the date of the billing record.
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Gets a value indicating whether the billing record has been processed.
        /// </summary>
        bool IsProcessed { get; }

        /// <summary>
        /// Gets the signed amount of the billing record.
        /// </summary>
        decimal SignedAmount { get; }
    }
}
