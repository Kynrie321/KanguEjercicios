using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            int[] Alice = new int[3];
            int[] BOB = new int[3];
            int[] Resultados = new int[3];
            string[] Tagpuntacion = new string[] { "Claridad", "Originalidad", "Dificultad"};
            Console.WriteLine("Añada la puntuación de Alice y Bob");
            Console.WriteLine("-------------------------------------------");
            
            
            void AsingarNotas(int[] n) { 
             for (int i = 0; i <3 ; i++)
                {              
                Console.Write(Tagpuntacion[i] + ". "); n[i] = int.Parse(Console.ReadLine());
                 
                }
            
            }
     

                Console.WriteLine("---Alice---");
                AsingarNotas(Alice);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("---Bob---");
                AsingarNotas(BOB);
                for (int i = 0; i < Alice.Length; i++)
                {
                if (BOB[i] > Alice[i])
                { 
                Resultados[1] = Resultados[1] + 1;
                }

                else if (BOB[i] < Alice[i])
                {
                Resultados[2] = Resultados[2] + 1;

                }
            }
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("La calificacion de Bob es: " + Resultados[1]);
                Console.WriteLine("La calificacion de Alice es: " + Resultados[2] );

            Console.ReadLine();
        }
    }
}
