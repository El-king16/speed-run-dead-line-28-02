using System;

namespace App_pc_knyazkov
{
    class Program
    {
        static void Main(string[] args)
        {
            //на тройку
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a^3-3a^2b+3ab^2-b^3 = {Math.Pow(a, 3) - Math.Pow(3 * a, 2) + 3 * a * Math.Pow(b, 3) - Math.Pow(b, 3)} ");
            Console.WriteLine($"a^3+3a^2b+3ab^2+b^3 = {Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) + Math.Pow(b, 3)}");
            Console.WriteLine($"(a+b)(a^2-ab+b^2) = {Math.Pow(a, 3) + Math.Pow(b, 3)}");
            Console.WriteLine($"(a-b)(a^2+ab+b^2) = {Math.Pow(a, 3) - Math.Pow(b, 3)}");
            Console.WriteLine($"(a-b)*(a+b) = {Math.Pow(a, 2) + Math.Pow(b, 2)}");
            Console.WriteLine($"a^2-2ab+b^2 {Math.Pow(a - b, 2)}");
            Console.WriteLine($"a^2+2ab+b^2 {Math.Pow(a + b, 2)}");

            //на четверку
            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"((a^2-4bc)/(a - a^1/2-ac)-(abc)^3)/(a^2-2ab+b^2) = {((Math.Pow(a, 2) - 4 * b * c) / (a - Math.Sqrt(a) - a * c) - Math.Pow(a * b * c, 3)) / Math.Pow(a - b, 2)}");

        }
    }
}
