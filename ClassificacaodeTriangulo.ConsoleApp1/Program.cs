

namespace ClassificacaodeTriangulo.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)

    {
        while (true)
        {
            Metodos.ExibirCabecalho();

            int ladox = Metodos.LerValoresDigitados("X");

            int ladoy = Metodos.LerValoresDigitados("Y");

            int ladoz = Metodos.LerValoresDigitados("Z");

            Metodos.ExibirValoresDigitados(ladox, ladoy, ladoz);

            bool medidasdotriangulovalidada = Metodos.ValidarTriangulo(ladox, ladoy, ladoz);

            Console.WriteLine(Metodos.ClassificarTriangulo(medidasdotriangulovalidada, ladox, ladoy, ladoz));

            Console.WriteLine("\n");

            Console.Write("Deseja continuar? (S?N)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if (opcaocontinuar != "S")
                break;
        }
    }

}

