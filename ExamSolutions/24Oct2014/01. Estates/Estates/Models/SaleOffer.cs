namespace Estates.Models
{
    using Interfaces;

    public class SaleOffer : Offer, ISaleOffer
    {
        public SaleOffer()
            : base(OfferType.Sale)
        {
        }

        public decimal Price { get; set; }

        public override string ToString()
        {
            string result = base.ToString() + this.Price;
            return result;
        }
    }
}
