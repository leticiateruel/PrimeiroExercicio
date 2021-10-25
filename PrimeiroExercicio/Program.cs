using System;
using System.Globalization;

namespace PrimeiroExercicio
{

    //Exercício 01
    class Soma
    {
        private void Main(string[] args)
        {
            int A, B, Soma;

            Console.WriteLine("Insira dois números inteiros :3");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            Soma = A + B;

            Console.WriteLine("A soma é: " + Soma);
        }
    }

    //Exercício 02
    class Raio
    {
        private void Main(string[] args)
        {
            double raio, area;
            double pi = 3.14159;

            Console.WriteLine("Insira o raio :3");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("A área é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }

    //Exercício 03
    class Diferenca
    {
        private void Main(string[] args)
        {
            int A, B, C, D, Diferenca;

            Console.WriteLine("Insira quatro números inteiros :3");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Diferenca = (A * B - C * D);
            Console.WriteLine("A diferença é: " + Diferenca);
        }
    }

    //Exercício 04
    class Funcionario
    {
        private void Main(string[] args)
        {
            int Id, NHoras;
            double VHoras, Salario;

            Console.WriteLine("Insira o Id: ");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de horas trabalhadas: ");
            NHoras = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor recebido por hora: ");
            VHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = NHoras * VHoras;

            Console.WriteLine("Número do funcionário: " + Id);
            Console.WriteLine("O salário é: R$" + Salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    //Exercício 05
    class Pecas
    {
        private void Main(string[] args)
        {
            int IdPeca1, IdPeca2, NPeca1, NPeca2;
            double VUnitarioPeca1, VUnitarioPeca2, Total;

            Console.WriteLine("Insira o Id, quantidade e valor unitário da peça 1 consecutivamente: ");
            string[] valores = Console.ReadLine().Split(' ');
            IdPeca1 = int.Parse(valores[0], CultureInfo.InvariantCulture);
            NPeca1 = int.Parse(valores[1], CultureInfo.InvariantCulture);
            VUnitarioPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Insira o Id, quantidade e valor unitário da peça 2 consecutivamente: ");
            string[] valores2 = Console.ReadLine().Split(' ');
            IdPeca2 = int.Parse(valores2[0], CultureInfo.InvariantCulture);
            NPeca2 = int.Parse(valores2[1], CultureInfo.InvariantCulture);
            VUnitarioPeca2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            Total = (NPeca1 * VUnitarioPeca1) + NPeca2 * VUnitarioPeca2;

            Console.WriteLine("Total do pedido: R$" + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    //Exercício 06
    class Triangulo
    {
        static void Main(string[] args)
        {
            double A, B, C, Triangulo, Circulo, Trapezio, Quadrado, Retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Triangulo = A * C / 2.0;
            Circulo = 3.14159 * (C * C);
            Trapezio = (A + B) / (2.0 * C);
            Quadrado = B * B;
            Retangulo = A * B;

            Console.WriteLine("Triângulo: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}