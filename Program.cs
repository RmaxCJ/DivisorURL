using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorURL
{
    class Program
    {
        static void Main(string[] args) 
        {
            String prueba;
            
            Console.Write("\tINTRODUCE UNA URL:       ");
            prueba = Console.ReadLine().ToLower();
            Link frase = new Link(prueba);
            
            Console.WriteLine("");
            frase.Separa();

            System.Console.WriteLine(" El protocolo es    \t" +frase.getProtocolo());
            System.Console.WriteLine(" El dominio es    \t" + frase.getDominio());
            System.Console.WriteLine(" El ruta es    \t" + frase.getRuta());

          


            Console.WriteLine("");

            System.Console.WriteLine("Presiona cualquier tecla para salir");
            System.Console.ReadKey();
          

        }

     }

}

