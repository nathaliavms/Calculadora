﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calculadora IMC");
            Console.WriteLine("2 - Calculadora Area Circulo");
            Console.WriteLine("3 - Calculadora regra de 3");
            Console.WriteLine("4 - Sair");

            return int.Parse(Console.ReadLine());

        }

        static string Calculo(int g)
        {
            var a = Menu();
            double resultado;
            if (a == 1)
            {
                Console.WriteLine("Informe primeiro seu peso e depois a sua altura (na mesma linha)");
                string[] vet = Console.ReadLine().Split(' ');
                int peso = int.Parse(vet[0]);
                double altura = double.Parse(vet[1]);
                resultado = peso / (altura * altura);

                if (resultado < 18.50)
                {
                    return "Você está abaixo do peso";
                }
                else if (resultado < 25.00)
                {
                    return "Você está com o peso normal";
                }
                else if (resultado < 30)
                {
                    return "Você está com sobrepeso";
                }
                else if (resultado < 35)
                {
                    return "Você está com obesidade grau I";
                }
                else if (resultado < 40)
                {
                    return "Você está com obesidade grau II";
                }
                else if (resultado >= 40)
                {
                    return "Você está com obesidade grau III";
                }
            }
        }
        static void Main(string[] args)
        {
            var a = Menu();
            double resultado;
            Console.WriteLine(Calculo(int a));

            

          
            /*
            if (a == 2)
            {
                    Console.WriteLine("Informe o raio do circulo");
                    int raio = int.Parse(Console.ReadLine());
                    resultado = 3.14 * (raio * raio);

                    Console.WriteLine(resultado);
            }

            else if (a == 3)
            {
                    Console.WriteLine("Informe 3 Números (na mesma linha)");
                    string[] vet2 = Console.ReadLine().Split(' ');
                    int n1 = int.Parse(vet[0]);
                    int n2 = int.Parse(vet[1]);
                    int n3 = int.Parse(vet[2]);

                    resultado = (n1 * n3) / n2;

                    Console.WriteLine(resultado);

            }
            else if (a == 4)
            {
                    Console.WriteLine("FINALIZADO COM SUCESSO!");
            }

            }*/

        }
    }
}
