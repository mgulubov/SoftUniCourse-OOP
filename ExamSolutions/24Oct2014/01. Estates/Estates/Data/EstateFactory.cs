namespace Estates.Data
{
    using System;
    using Engine;
    using Interfaces;
    using Models;

    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EstateEngineExtended();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.House:
                    return new House();
                case EstateType.Apartment:
                    return new Apartment();
                case EstateType.Garage:
                    return new Garage();
                case EstateType.Office:
                    return new Office();
                default:
                    throw new ArgumentOutOfRangeException(type.ToString(), "EstateType not supported");
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Rent:
                    return new RentOffer();
                case OfferType.Sale:
                    return new SaleOffer();
                default:
                    throw new ArgumentOutOfRangeException(type.ToString(), "OfferType not supported");
            }
        }
    }
}
