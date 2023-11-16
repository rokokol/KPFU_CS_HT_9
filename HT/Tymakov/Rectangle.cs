namespace Tymakov
{
    public class Rectangle : Dot, IGetSpace
    {
        public uint width;
        public uint height;

        public double GetSpace()
        {
            return width * height;
        }

        public override string ToString()
        {
            return $"Rectandle - x: {x}, y: {y}, color: {Color}, visibility: {Visibility}," +
            	$" width: {width}, height: {height}";
        }

        public Rectangle(int x, int y, string color, uint width, uint height) : base(x, y, color)
        {
            this.width = width;
            this.height = height;
        }
    }
}
