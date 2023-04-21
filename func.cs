
namespace func
{
    internal class func
    {

        static double CalculateSquareRoot(double targett)
        {
            double x = 1;
            double oldx;

            do
            {
                oldx = x;
                x = (x + targett / x) / 2;
            } while (oldx != x);

            return x;

        }
        static void Main(string[] args)
        {

            double target = 2023;
            CalculateSquareRoot(target);

            Console.WriteLine($"x = {CalculateSquareRoot(target)}");
            Console.WriteLine($"x^2 = {Math.Round(Math.Pow(CalculateSquareRoot(target), 2))}");
        }
    }
}