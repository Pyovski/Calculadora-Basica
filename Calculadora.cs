using System;

namespace bootcamp_2
{
    public class Calculadora
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
        }
    }
}