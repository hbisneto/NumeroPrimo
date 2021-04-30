using System;

namespace NumeroPrimo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var CopyrightClass = new Copyright();
            CopyrightClass.Print();

            int Qtd = 0;

            Console.WriteLine(">> Informe um Número: ");
            int IntNumero = Convert.ToInt32(Console.ReadLine());

            for (int N = 1; N <= IntNumero + 1; N++)
            {
                int Resto = IntNumero % N;

                if (Resto == 0)
                {
                    Qtd += 1;
                }
            }

            if (Qtd == 2)
            {
                Console.WriteLine();
                Console.WriteLine(">> O número " + IntNumero + " é um número primo");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(">> O número " + IntNumero + " não é um número primo");
            }
        }
    }
}








