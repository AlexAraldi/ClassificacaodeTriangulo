using System;
using System.ComponentModel.Design;

namespace ClassificacaodeTriangulo.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)

    {
        while (true)
        {
            ExibirCabecalho();

            int ladox = LerValoresDigitados("X");

            int ladoy = LerValoresDigitados("Y");

            int ladoz = LerValoresDigitados("Z");

            ExibirValoresDigitados(ladox, ladoy, ladoz);

            bool medidasdotriangulovalidada = ValidarTriangulo(ladox, ladoy, ladoz);

            Console.WriteLine(ClassificarTriangulo(medidasdotriangulovalidada, ladox, ladoy, ladoz));

            Console.WriteLine("\n");

            Console.Write("Deseja continuar? (S?N)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if (opcaocontinuar != "S")
                break;
        }
    }
    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("__________________________");
        Console.WriteLine("Classificação do Triangulo");
        Console.WriteLine("__________________________");
        Console.WriteLine("\n");
    }
    static int LerValoresDigitados(string lado)
    {
        int valor;
        while (true)
        {
            Console.Write($"Informe o lado de {lado}: ");

            bool conseguiuconverter = int.TryParse(Console.ReadLine(), out valor);
            if (conseguiuconverter)
                break;
        }
        return valor;
    }
    static void ExibirValoresDigitados(int ladox, int ladoy, int ladoz)
    {
        Console.WriteLine("Valor de X: " + ladox);
        Console.WriteLine("Valor de Y: " + ladoy);
        Console.WriteLine("Valor de Z: " + ladoz);
    }
    static bool ValidarTriangulo(int ldx, int ldy, int ldz)
    {
        bool medidasdotriangulovalidada = ldx + ldy > ldz && ldx + ldz > ldy && ldz + ldy > ldx;
        return medidasdotriangulovalidada;
    }
    static string ClassificarTriangulo(bool validada, int ldx, int ldy, int ldz)
    {
        if (validada == true)
        {
            if (ldx == ldy && ldy == ldz)
                return " O Triângulo é equilátero ";

            else if (ldx != ldy && ldy != ldz && ldx != ldz)
                return " O Triângulo é escaleno!";
            else
                return " O Triângulo é Isósceles";
        }
        else
            return " >> Valores do Triangulo é inválida << ";

    }
}

