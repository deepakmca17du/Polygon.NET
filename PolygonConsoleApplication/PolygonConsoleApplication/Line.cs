namespace PolygonConsoleApplication
{
    public class Line
    {
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public override string ToString()
        {
            return $"Start Point: {StartPoint.X},{StartPoint.Y} End Point: {EndPoint.X},{EndPoint.Y}";
        }

        public double GetLength()
        {
            var deltaX = EndPoint.X - StartPoint.X;
            var deltaY = EndPoint.Y - StartPoint.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
