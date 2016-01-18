namespace Estates.Models
{
    using Interfaces;

    public class Garage : Estate, IGarage
    {
        public Garage()
            : base(EstateType.Garage)
        {
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            string result = base.ToString() + string.Format(", Width: {0}, Height: {1}", this.Width, this.Height);
            return result;
        }
    }
}
