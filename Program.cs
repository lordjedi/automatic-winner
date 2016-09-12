using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario;
            bool pudoParsear;
            //int antes, despues, centroNumerico;
            int antes, despues;
 
            Console.Title = "Ejercicio Nro 10";
            Console.WriteLine("Ingrese un numero");
            pudoParsear = int.TryParse(Console.ReadLine(), out numeroUsuario);
            while (pudoParsear == false)
            {
                Console.WriteLine("ERROR, reingrese");
                pudoParsear = int.TryParse(Console.ReadLine(), out numeroUsuario);
            }
            for (int i = 1; i < numeroUsuario; i++)
            {
                antes = 0;
                despues = 0;
                for (int j = 1; j < i; j++)
                {
                    antes += j;
                    //Console.WriteLine("ANTES: {0}", antes);
                }
                int counter = 1;
                while (despues < antes)
                {
                    
                    despues += i + counter;
                    //Console.WriteLine("DESPUES: {0}", despues);
                    counter++;
                }
                if (antes == despues)
                    Console.WriteLine(i);
                
            }
            Console.ReadKey();
        }
    }
}
