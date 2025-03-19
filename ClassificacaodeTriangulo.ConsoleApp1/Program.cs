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

            //////// interacao do usuario ( retorno externo )______________________________________
            int ladox;
                while (true)
            {
                Console.Write("Informe o lado de X: ");

                bool conseguiuconverter = int.TryParse(Console.ReadLine(), out ladox);
                if (conseguiuconverter)
                    break;
            }

            int ladoy;
            while (true)
            {
                Console.Write("Informe o lado de Y: ");

                bool conseguiuconverter = int.TryParse(Console.ReadLine(), out ladoy);
                if (conseguiuconverter)
                    break;
            }
            int ladoz;
            while (true)
            {
                Console.Write("Informe o lado de Z: ");

                bool conseguiuconverter = int.TryParse(Console.ReadLine(), out ladoz);
                if (conseguiuconverter)
                    break;
            }

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
