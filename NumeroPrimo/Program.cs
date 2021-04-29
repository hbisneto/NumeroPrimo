using System;

namespace NumeroPrimo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string SoftwareName = "NumeroPrimo";
            string Version = "1.1";
            string CopyrightName = "Heitor Bisneto.";
            DateTime AnoAtual = DateTime.Today;

            Console.WriteLine("Nome: " + SoftwareName);
            Console.WriteLine("Versão: " + Version);
            Console.WriteLine("Criado por: " + CopyrightName);

            string StrAnoAtual = AnoAtual.ToString("yyyy");
            int IntAnoAtual = Convert.ToInt32(StrAnoAtual);

            if (IntAnoAtual == 2021)
            {
                Console.WriteLine("Copyright © " + IntAnoAtual + " | " + CopyrightName + " All rights reserved.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Copyright © 2020 - " + IntAnoAtual + " | " + CopyrightName + " All rights reserved.");
                Console.WriteLine();
            }

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








