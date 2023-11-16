namespace Tymakov
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public string Color { get; set; }
        public bool Visibility { get; set; }

        public virtual void MoveX(int x)
        {
            this.x += x;
        }

        public virtual void MoveY(int y)
        {
            this.y += y;
        }
    }
}
