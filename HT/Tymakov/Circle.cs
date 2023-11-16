using System;
namespace Tymakov
{
    public class Circle : Dot, IGetSpace
    {
        public uint rad;

        public double GetSpace()
        {
            return Math.PI * rad * rad;
        }

        public override string ToString()
        {
            return $"Circle - x: {x}, y: {y}, color: {Color}, visibility: {Visibility}, radius: {rad}";
        }

        public Circle(int x, int y, string color, uint rad) : base(x, y, color)
        {
            this.rad = rad;
        }
    }
}
