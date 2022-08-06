namespace PolygonConsoleApplication
{
    public class Rectangle: Polygon
    {
   
        public Rectangle(Point center, double length, double width): base(GetVertices(center, length, width))
        {
        }

        private static List<Point> GetVertices(Point center, double length, double width)
        {
            var topLeftPoint = new Point
            {
                X = center.X - width / 2,
                Y = center.Y + length / 2
            };
            var topRightPoint = new Point
            {
                X = center.X + width / 2,
                Y = center.Y + length / 2
            };
            var bottomRightPoint = new Point
            {
                X = center.X + width / 2,
                Y = center.Y - length / 2
            };
            var bottomLeftPoint = new Point
            {
                X = center.X - width / 2,
                Y = center.Y - length / 2
            };

            return new List<Point> { topLeftPoint, topRightPoint, bottomRightPoint, bottomLeftPoint };

        }
    }
}
