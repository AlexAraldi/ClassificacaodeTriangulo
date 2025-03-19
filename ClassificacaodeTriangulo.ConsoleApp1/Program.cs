namespace ClassificacaodeTriangulo.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            // inicio 
            Console.Clear();
            Console.WriteLine("__________________________");
            Console.WriteLine("Classificação do Triangulo");
            Console.WriteLine("__________________________");


            // logica
            Console.WriteLine("Informe o lado de X:");
            int ladox = Convert.ToInt32(Console.ReadLine(ladox));

            Console.WriteLine("Informe o lado de Y:");
            int ladoy = Convert.ToInt32(Console.ReadLine(ladoy));

            Console.WriteLine("Informe o lado de Z:");
            int ladoz = Convert.ToInt32(Console.ReadLine(ladoz));

            // interacao do usuario ( retorno externo )


            Console.Write("Valor de X: " + ladox);
            Console.Write("Valor de Y: " + ladoy);
            Console.Write("Valor de Z: " + ladoz);


            // final 
            Console.Write("Deseja continuar? (S?N)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if(opcaocontinuar!= "S")
            break;


        }




    }
}
