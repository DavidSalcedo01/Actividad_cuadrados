using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_cuadrado
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int grande = 0;
            string hueco = null;
            
            Console.WriteLine("Ingrese el tamaño del cubo");

            try
            {
                grande = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sobrepaso el tamaño permitido");
            }
            
            Console.WriteLine("Tendra un hueco en medio  (Si o No)");

            try
            {
                hueco = Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Solo escriba Si o No");
            }
            int comp = string.Compare(hueco, "si", true);
            if (comp == 0)
            {
                huecoCubo(grande);
            }
            else
            {
                cubo(grande);
            }





        }
        public static void cubo(int tam)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < tam; i++)
            {
                for (int l = 0; l < tam; l++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public static void huecoCubo(int tam)
        {
            string[,] areglo = new string[tam, tam];

            for (int i = 0; i < tam; i++)
            {
                for (int l = 0; l < tam; l++)
                {
                    areglo[i, l] =  " *";
                }
            }

            if (tam % 2 == 0)
            {
                int medio = tam / 2;
                areglo[medio, medio] = "  ";
                areglo[medio - 1, medio - 1] = "  ";
                areglo[medio, medio - 1] = "  ";
                areglo[medio - 1, medio] = "  ";
            }
            else
            {
                int medio = tam / 2;
                areglo[medio, medio] = "  ";
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < tam; i++)
            {
                for (int l = 0; l < tam; l++)
                {
                    Console.Write(areglo[i, l]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
            Console.ResetColor();


        }
    }
}
