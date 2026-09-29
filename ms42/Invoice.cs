using System.Collections.Generic;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents an invoice for a guest's stay and services.
    /// </summary>
    public class Invoice
    {
        public string GuestName { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;
        public List<BillingRecord> BillingRecords { get; } = new List<BillingRecord>();

        /// <summary>
        /// Gets the total amount of processed charges.
        /// </summary>
        public decimal TotalCharges
        {
            get
            {
                decimal total = 0m;

                foreach (BillingRecord record in BillingRecords)
                {
                    if (record is Charge && record.IsProcessed)
                    {
                        total += record.Amount;
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

                foreach (BillingRecord record in BillingRecords)
                {
                    if (record is Payment && record.IsProcessed)
                    {
                        total += record.Amount;
                    }
                }

                return total;
            }
        }

        /// <summary>
        /// Gets the amount remaining after processed charges and payments.
        /// </summary>
        public decimal BalanceDue
        {
            get
            {
                decimal balance = 0m;

                foreach (BillingRecord record in BillingRecords)
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
        /// Gets Paid when the balance is zero or less; otherwise gets Unpaid.
        /// </summary>
        public string Status => BalanceDue <= 0m ? "Paid" : "Unpaid";
    }
}
