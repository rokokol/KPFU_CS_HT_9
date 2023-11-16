using System;
namespace Tymakov
{
    public class Dot : Figure
    {
        public Dot(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            Color = color;
        }

        public override string ToString()
        {
            return $"Dot - x: {x}, y: {y}, color: {Color}, visibility: {Visibility}";
        }
    }
}
