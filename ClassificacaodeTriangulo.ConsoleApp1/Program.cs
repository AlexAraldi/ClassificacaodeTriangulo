using System.ComponentModel.Design;

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
            Console.WriteLine("\n");

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
            {
                
                // equilatero = todos lados iguais
                // isosceles = dois lados iguis
                // escaleno = todos os lados diferentes

                string tipodetriangulo = "Não Classificado";
                    if (ladox == ladoy && ladoy == ladoz)
                tipodetriangulo = " O Triângulo é equilátero ";

                    else if (ladox != ladoy && ladoy != ladoz && ladox != ladoz)
                tipodetriangulo = " O Triângulo é escaleno!";

                    else 
                tipodetriangulo = " O Triângulo é Isósceles";

                Console.WriteLine("\n");

                Console.WriteLine($" ** O Triangulo é {tipodetriangulo} ** ");
            }

            else
            Console.WriteLine(" >> Valores do Triangulo é inválida << ");

            ///////// final ____________________________________________________________________ 
            Console.WriteLine("\n");

            Console.Write("Deseja continuar? (S?N)");
            string opcaocontinuar = Console.ReadLine()!.ToUpper();

            if(opcaocontinuar!= "S")
            break;


        }




    }
}
