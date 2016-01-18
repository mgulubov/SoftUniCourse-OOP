namespace Estates.Models
{
    using Interfaces;

    public abstract class Estate : IEstate
    {
        protected Estate(EstateType type)
        {
            this.Type = type;
        }

        public string Name { get; set; }
        public EstateType Type { get; set; }
        public double Area { get; set; }
        public string Location { get; set; }
        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            string result = string.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",
                this.Type, this.Name, this.Area, this.Location, this.IsFurnished ? "Yes" : "No");

            return result;
        }
    }
}
