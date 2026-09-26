using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Task 1");
        int n, m, r1;
        bool r2, r3;
        double x;
        Console.Write("n?");
        while (!(int.TryParse(Console.ReadLine(), out n)))
            Console.Write("Invalid input! n?");
        Console.Write("m?");
        while (!(int.TryParse(Console.ReadLine(), out m)))
            Console.Write("Invalid input! m?");
        r1 = n++ * --m;
        Console.WriteLine($"n++ * --m = {r1} (n={n}, m={m})");
        r2 = n-- < m++;
        Console.WriteLine($"n-- < m++ = {r2} (n={n}, m={m})");
        r3 = --n > --m;
        Console.WriteLine($"--n > --m = {r3} (n={n}, m={m})");
        Console.Write("x?");
        while(!(double.TryParse(Console.ReadLine(), out x)))
            Console.Write("Invalid input! x?");
        if (x == 0)
            Console.WriteLine("Division by zero!");
        else
        {
            double inner = 1.0/(x*x) + 1.0/(x*x*x);
            double res;
            if (inner < 0)
            {
                res = 5 * Math.Pow(x, 3) * -Math.Pow(-inner, 1.0/5.0);
                Console.WriteLine($"5x^3*sqrt5(1/x^2+1/x^3) = {res}");
            }
            else
            {
                res = 5 * Math.Pow(x, 3) * Math.Pow(inner, 1.0/5.0);
                Console.WriteLine($"5x^3*sqrt5(1/x^2+1/x^3) = {res}");
            }
        }
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.WriteLine("Task 2");
        double x1, y1;
        Console.Write("x1?");
        while (!(double.TryParse(Console.ReadLine(), out x1)))
            Console.Write("Invalid input! x1?");
        Console.Write("y1?");
        while (!(double.TryParse(Console.ReadLine(), out y1)))
            Console.Write("Invalid input! y1?");
        bool isInside = (y1 >= 0) && (y1 <= 5 - Math.Abs(x1)) 
            || (x1 >= 0) && (y1 <= 0) && (y1 >= (7.0/5.0)*x1 - 7);
        Console.WriteLine($"\"Point ({x1}; {y1}) belongs to the figure\" is {isInside}");
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.WriteLine("Task 3");
        double ad = 1000, bd = 0.0001;
        double numD = Math.Pow(ad - bd, 2) - (Math.Pow(ad, 2) - 2*ad*bd);
        double resD = numD / (bd * bd);
        Console.WriteLine($"double: {resD}");

        float af = 1000f, bf = 0.0001f;
        float numF = (float)Math.Pow(af - bf, 2) - ((float)Math.Pow(af, 2) - 2*af*bf);
        float resF = numF / (bf * bf);
        Console.WriteLine($"float:  {resF}");

        
    }
}
