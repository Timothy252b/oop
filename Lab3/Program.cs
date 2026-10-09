using System;

class Program
{
    static void Main()
    {
        const double xLeft = 0.1;
        const double xRight = 1.0;
        const int pointsCount = 10;
        const int n = 30;
        const double epsilon = 0.0001;

        double step = (xRight - xLeft) / (pointsCount - 1);

        Console.WriteLine("X\tSumN\t\tSumE\t\tY");
        for (double x = xLeft; x <= xRight + step / 2; x += step)
        {
            Console.Write($"{x:F2}\t");
            Console.Write($"{SumN(x, n):F8}\t");
            Console.Write($"{SumE(x, epsilon):F8}\t");
            Console.Write($"{ExactValue(x):F8}\n");
        }
    }

    
    static double SumN(double x, int n)
    {
        double a_i = 1.0;   
        double sum = 1.0;   

        for (int i = 0; i < n; i++)
        {
            
            a_i *= ((i * i + 2 * i + 2) * x) / ((i + 1) * (i * i + 1) * 2);
            sum += a_i;
        }
        return sum;
    }

    
    static double SumE(double x, double epsilon)
    {
        double a_i = 1.0;  
        double sum = 1.0;   
        int i = 0;

        while (true)
        {
            
            a_i *= ((i * i + 2 * i + 2) * x) / ((i + 1) * (i * i + 1) * 2);
            i++;
            sum += a_i;
            if (Math.Abs(a_i) < epsilon)
                break;
        }
        return sum;
    }

    static double ExactValue(double x)
    {
        return ((x * x) / 4 + x / 2 + 1) * Math.Exp(x / 2);
    }
}
