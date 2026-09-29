using InnManager.Enums;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents a payment made by a guest.
    /// </summary>
    public class Payment : BillingRecord
    {
        /// <summary>
        /// Method used for the payment.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;

        public bool IsSuccessful { get; set; } = false;

        /// <summary>
        /// Gets the negative amount applied by the payment.
        /// </summary>
        public override decimal SignedAmount => -Amount;
    }
}
