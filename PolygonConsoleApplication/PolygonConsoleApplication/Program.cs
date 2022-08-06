namespace PolygonConsoleApplication
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Rectangle's X Coordinate:");
                double X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Rectangle's Y Coordinate:");
                double Y = Convert.ToDouble(Console.ReadLine());
                var center = new Point { X = X, Y = Y };

                Console.WriteLine("Enter Rectangle's Length(>0):");
                double length = Convert.ToDouble(Console.ReadLine());
                ValidateDimension(length);

                Console.WriteLine("Enter Rectangle's Width(>0):");
                double width = Convert.ToDouble(Console.ReadLine());
                ValidateDimension(width);

                var rectangle = new Rectangle(center, length, width);
                var len = rectangle.GetLength();
                Console.WriteLine($"Rectangle Length = {len}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            
        }

        private static void ValidateDimension(double value)
        {
            try
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value should be greater than 0");
                }

                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
