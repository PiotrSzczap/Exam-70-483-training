namespace CreateTypes
{
    public struct Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public static Point Create(int p1, int p2) => new Point(p1, p2);
    }
}
