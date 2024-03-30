using bootcamp_2;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        calc.Somar(10, 20.4);
        calc.Dividir(10, 4);
        calc.Subtrair(10, 5);
        calc.Dividir(40, 4);
   }
}