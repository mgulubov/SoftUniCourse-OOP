namespace Estates.Models
{
    using Interfaces;

    public class Office : BuildingEstate, IOffice
    {
        public Office()
            : base(EstateType.Office)
        {
        }
    }
}
