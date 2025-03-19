namespace ClassificacaodeTriangulo.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ///////// inicio _______________________________________________________________________
            Console.Clear();
            Console.WriteLine("__________________________");
            Console.WriteLine("Classificação do Triangulo");
            Console.WriteLine("__________________________");

            ///////// logica________________________________________________________________________
            Console.Write("Informe o lado de X: ");
            int ladox = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o lado de Y: ");
            int ladoy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o lado de Z: ");
            int ladoz = Convert.ToInt32(Console.ReadLine());

            //////// interacao do usuario ( retorno externo )______________________________________
            Console.WriteLine("Valor de X: "+ladox);
            Console.WriteLine("Valor de Y: "+ladoy);
            Console.WriteLine("Valor de Z: "+ladoz);

            //////// verificacao do triangulo _____________________________________________________
            bool medidasdotriangulovalidada =  
            ladox + ladoy > ladoz &&
            ladox + ladoz > ladoy &&
            ladoz + ladoy > ladox;

            if (medidasdotriangulovalidada == true)
            Console.WriteLine(" ** O Triangulo é Válido ** ");
            else
            Console.WriteLine(" >> Valores do Triangulo é inválida << ");

            ///////// final ____________________________________________________________________ 
            Console.Write("Deseja continuar? (S?N)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if(opcaocontinuar!= "S")
            break;


        }




    }
}
