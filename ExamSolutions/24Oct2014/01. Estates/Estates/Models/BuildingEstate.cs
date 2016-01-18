namespace Estates.Models
{
    using Interfaces;

    public abstract class BuildingEstate : Estate, IBuildingEstate
    {
        protected BuildingEstate(EstateType type)
            :base(type)
        {
        }

        public int Rooms { get; set; }
        public bool HasElevator { get; set; }

        public override string ToString()
        {
            string result = base.ToString() + string.Format(", Rooms: {0}, Elevator: {1}", 
                this.Rooms, this.HasElevator ? "Yes" : "No");

            return result;
        }
    }
}
