using System;
namespace ind_2.1.1
{
    class Program
    {
        public static double GetFunctionValueconst (double a,  double eps)
        {
            double n = a;
            double sum = 0.0;
            int i = 0;

            do
            {
                sum += n;
                n *= (2 * (Math.Pow(a, 2 * n + 1)) / (2 * n + 1));
                i++;
            }
            while (Math.Abs(n) >= eps);

            return sum;
        }
        public static double GetSeriesValue(double a, double b, double c, double r)
        {
            if (r < 0 && b != 0)
            {
                return a - (r / (10 + b));
            }
            if ((r > 0) && (b == 0))
            {
                return (r - a) / (r - c);
            }
            return 3 * r + 2 / c;
        }
        public static void Main(string[] args)
        {
            int  countforFunc = -1, countForGets = -1;
            object[] arrforFunc = new object[81];
            object[] arrforGets = new object[81];
            double a, b, c, xn, xk, r, x;
            double dx = 0.1;
            double eps = 0.001;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            Console.Write("xn=");
            xn = double.Parse(Console.ReadLine());
            Console.Write("xk=");
            xk = double.Parse(Console.ReadLine());
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());
            r = x;
            for (r = xn; xk >= r; r += dx)
            {
           
                countforFunc++;
                arrforFunc[countforFunc] = GetSeriesValue(a, b, c, r);
                arrforFunc[countforFunc] = (double)arrforFunc[0] + countforFunc * dx;
                Console.WriteLine("|{1}| element = {0}", arrforFunc[countforFunc], countforFunc);

            }
            Console.WriteLine();
           
                for (a = -0.9; a <= 0.9; a += 0.1)
                {
                countForGets++;
                arrforGets[countForGets] = GetFunctionValueconst (a, eps);
                arrforGets[countForGets] = (double)arrforGets[0] + (countForGets * dx); 
                Console.WriteLine("{1} element =|{0}|", arrforGets[countForGets], countForGets);
               
                }

            Console.ReadKey(true);
        }
    }
}