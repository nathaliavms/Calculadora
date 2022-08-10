using System;


namespace Exercicio
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

        static string RetornaClassificacaoImc(double a, double b)
        {
            double calculo;
            

            calculo = a / (b * b);

            if (calculo < 18.50)
            {
                return "Você está abaixo do peso";
            }
            else if (calculo < 25.00)
            {
                return "Você está com o peso normal";
            }
            else if (calculo < 30)
            {
                return "Você está com sobrepeso";
            }
            else if (calculo < 35)
            {
                return "Você está com obesidade grau I";
            }
            else if (calculo < 40)
            {
                return "Você está com obesidade grau II";
            }
            else if (calculo >= 40)
            {
                return "Você está com obesidade grau III";
            }
            else
            {
                return "Invalido";
            }
        }

        static void CalcularImc()
        {
            Console.WriteLine("Digite seu peso:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            double b = double.Parse(Console.ReadLine());
            RetornaClassificacaoImc(a, b);
        }

        static double CalcularArea()
        {
            double resultado;
            Console.WriteLine("Informe o raio do circulo");
            double raio = double.Parse(Console.ReadLine());
            resultado = 3.14 * (raio * raio);
            return resultado;

        }

        static double CalcularRegra3()
        {
            double resultado;
            Console.WriteLine("Informe valores A, B e C (na mesma linha)");
            string[] vet2 = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vet2[0]);
            double n2 = double.Parse(vet2[1]);
            double n3 = double.Parse(vet2[2]);
            resultado = (n1 * n3) / n2;

            return resultado;
            
        }

        static void Main(string[] args)
        {
            var a = Menu();

            if (a == 1)
            {
                CalcularImc();
 
            }

            else if (a == 2)
            {
                CalcularArea();
            }

            else if (a == 3)
            {
                CalcularRegra3();

            }
            else if (a == 4)
            {
                Console.WriteLine("FINALIZADO COM SUCESSO!");
            }
        }

    }

}
