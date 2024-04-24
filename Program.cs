namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate double myDelegate(double x, double y);
        //custom
        static double GetSum(double x, double y)
        {
            return x + y;
        }
        //func
        /*public double GetProduct(double a, double b)
        {
            return a * b;
        }
        //action
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }*/
        static void Main(string[] args)
        {
            // create a class object
            
            
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double a = Math.Round(r.NextDouble() * 100);
            double b = Math.Round(r.NextDouble() * 100);
            
            Action<double, double> calcSmaller = delegate (double a, double b){
                if (a < b)
                    Console.WriteLine($" {a} is smaller than {b}");
                else if (b < a)
                    Console.WriteLine($" {b} is smaller than {a}");
                else
                    Console.WriteLine($" {b} is equal to {a}");
            };
            calcSmaller(a, b);

            Func<double, double, double> calcProduct = delegate (double a, double b)
            {
                Console.WriteLine($" {a} * {b} = {a*b} ");
                return a * b;
            };
            calcProduct(a, b);

            myDelegate d1 = new myDelegate(MathSolutions.GetSum);
            Console.WriteLine($" {a} + {b} = {d1(a, b)}");
        }
    }
}