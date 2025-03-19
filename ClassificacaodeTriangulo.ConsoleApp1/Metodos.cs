namespace ClassificacaodeTriangulo.ConsoleApp1;

class Metodos
{
    public static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("__________________________");
        Console.WriteLine("Classificação do Triangulo");
        Console.WriteLine("__________________________");
        Console.WriteLine("\n");
    }
    public static int LerValoresDigitados(string lado)
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
    public static void ExibirValoresDigitados(int ladox, int ladoy, int ladoz)
    {
        Console.WriteLine("Valor de X: " + ladox);
        Console.WriteLine("Valor de Y: " + ladoy);
        Console.WriteLine("Valor de Z: " + ladoz);
    }
    public static bool ValidarTriangulo(int ldx, int ldy, int ldz)
    {
        bool medidasdotriangulovalidada = ldx + ldy > ldz && ldx + ldz > ldy && ldz + ldy > ldx;
        return medidasdotriangulovalidada;
    }
    public static string ClassificarTriangulo(bool validada, int ldx, int ldy, int ldz)
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
