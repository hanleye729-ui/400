using InnManager.Enums;

namespace InnManager.Billing
{
    /// <summary>
    /// Represents an amount added to a guest's invoice.
    /// </summary>
    public class Charge : BillingRecord
    {
        /// <summary>
        /// Gets or sets the category of the charge.
        /// </summary>
        public ChargeCategory Category { get; set; } = ChargeCategory.Miscellaneous;

        /// <summary>
        /// Gets the positive amount added to the invoice.
        /// </summary>
        public override decimal SignedAmount => Amount;
    }
}
