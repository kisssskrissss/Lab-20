using System;

namespace Lab_20
{
    class Program
    {
        delegate double MyDelegate (double r);
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Length;
            double D = myDelegate(r);
            Console.WriteLine(D);

            myDelegate = Square;
            double S = myDelegate(r);
            Console.WriteLine(S);

            myDelegate = Volume;
            double V = myDelegate(r);
            Console.WriteLine(V);

            Console.ReadKey();
        }
        static double Length( double r)
        {
            double D = 2 * Math.PI * r;            
            return D;
        }
        static double Square(double r)
        {
            double S = Math.PI * r * r;
            return S;
        }
        static double Volume(double r)
        {
            double V =4/3* Math.PI * r*r * r;
            return V;
        }
    }
}
