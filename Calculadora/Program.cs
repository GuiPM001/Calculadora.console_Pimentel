using System;
using System.Collections.Generic;
using Application;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            var valores = ObterValores();

            float resultado = Operacoes.Somar(valores[0], valores[1]);
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            var valores = ObterValores();

            float resultado = Operacoes.Subtracao(valores[0], valores[1]);
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            var valores = ObterValores();

            float resultado = Operacoes.Divisao(valores[0], valores[1]);
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            var valores = ObterValores();

            float resultado = Operacoes.Multiplicacao(valores[0], valores[1]);
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static List<float> ObterValores()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            return new List<float>() { v1, v2 };
        }
    }
}
