using System;

namespace Ejercicio_1
{
    class Program
    {   
        static void Main(string[] args)
        {

            int n;
            Console.Write("Añada el tamaño del vector (0 al 1000): "); n = int.Parse(Console.ReadLine());
            int[] valores = new int[n];
            int SumaDevector = 0;
                
            if (n <= 1000) { 

            for (int i = 0; i < n; i++)
            {

                Console.Write((i+1) + ". " ); valores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < valores.Length; i++)
            {
                SumaDevector += valores[i];
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("La suma de los elementos del vector es: " + SumaDevector);
            }
            
            else
            {
                Console.WriteLine("El numero esta fuera de rango");
                
            }

            Console.ReadLine();
        }   
    }
}
