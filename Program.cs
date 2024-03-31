using System;
using bootcamp_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Calculadora calc = new Calculadora();

        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                calc.Somar(numero1, numero2);
                break;
            case 2:
                calc.Subtrair(numero1, numero2);
                break;
            case 3:
                calc.Multiplicar(numero1, numero2);
                break;
            case 4:
                calc.Dividir(numero1, numero2);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}