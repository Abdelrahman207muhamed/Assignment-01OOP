namespace Assignment_01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            
            Console.Write("Enter X for Point 1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y for Point 1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter X for Point 2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y for Point 2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());


            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));


            Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion
        }
    }
}
