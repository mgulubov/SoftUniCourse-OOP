namespace Estates.Models
{
    using Interfaces;

    public class House : Estate, IHouse
    {
        public House()
            : base(EstateType.House)
        {
        }

        public int Floors { get; set; }

        public override string ToString()
        {
            string result = base.ToString() + string.Format(", Floors: {0}", this.Floors);
            return result;
        }
    }
}
