namespace Estates.Models
{
    using Interfaces;

    public class RentOffer : Offer, IRentOffer
    {
        public RentOffer()
            : base(OfferType.Rent)
        {
        }

        public decimal PricePerMonth { get; set; }

        public override string ToString()
        {
            string result = base.ToString() + this.PricePerMonth;
            return result;
        }
    }
}
