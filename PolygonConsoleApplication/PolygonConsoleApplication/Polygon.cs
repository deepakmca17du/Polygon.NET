namespace PolygonConsoleApplication
{
    public class Polygon
    {
        private readonly List<Point> vertices;

        public Polygon(List<Point> vertices)
        {
            this.vertices = vertices;
        }

        public double GetLength()
        {
            double length = 0;
            var verticesCount = vertices.Count;
            for (var i = 0; i < verticesCount; i++)
            {
                var line = new Line {
                    StartPoint = vertices[i],
                    EndPoint = vertices[(i + 1) % verticesCount]
                };
                length += line.GetLength();
            }

            return length;
        }

    }
}
