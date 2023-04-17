using System;

class Program
{
    static void Main(string[] args)
    {
        int A = 6; // замените на нужное значение

        int A2 = A * A;
        Console.WriteLine("A^2 = " + A2);

        int A3 = A2 * A;
        Console.WriteLine("A^3 = " + A3);

        int A5 = A3 * A2;
        Console.WriteLine("A^5 = " + A5);

        int A10 = A5 * A5;
        Console.WriteLine("A^10 = " + A10);

        int A15 = A10 * A5;
        Console.WriteLine("A^15 = " + A15);
    }
}
