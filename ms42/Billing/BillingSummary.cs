using System.Collections.Generic;

namespace InnManager.Billing
{
    /// <summary>
    /// Provides read-only summary values for billing records.
    /// </summary>
    public class BillingSummary
    {
        private readonly IEnumerable<IBillingRecord> _records;

        /// <summary>
        /// Gets the total amount of processed charges.
        /// </summary>
        public decimal TotalCharges
        {
            get
            {
                decimal total = 0m;

                foreach (IBillingRecord record in _records)
                {
                    if (record.IsProcessed && record.SignedAmount > 0m)
                    {
                        total += record.SignedAmount;
                    }
                }

                return total;
            }
        }

        /// <summary>
        /// Gets the total amount of processed payments.
        /// </summary>
        public decimal TotalPayments
        {
            get
            {
                decimal total = 0m;

                foreach (IBillingRecord record in _records)
                {
                    if (record.IsProcessed && record.SignedAmount < 0m)
                    {
                        total += -record.SignedAmount;
                    }
                }

                return total;
            }
        }

        /// <summary>
        /// Gets the net balance of processed billing records.
        /// </summary>
        public decimal NetBalance
        {
            get
            {
                decimal balance = 0m;

                foreach (IBillingRecord record in _records)
                {
                    if (record.IsProcessed)
                    {
                        balance += record.SignedAmount;
                    }
                }

                return balance;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSummary"/> class.
        /// </summary>
        /// <param name="records">The billing records to summarize.</param>
        public BillingSummary(IEnumerable<IBillingRecord> records)
        {
            _records = records ?? new List<IBillingRecord>();
        }
    }
}
