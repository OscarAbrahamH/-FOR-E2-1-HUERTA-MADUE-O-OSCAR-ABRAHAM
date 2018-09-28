using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1_HUERTA_MADUEÑO_OSCAR_ABRAHAM
{
    class FACTORIAL
    {
        public int Numero;
        public int Resultado = 1;

        public void FactorValor()
        {
            Numero = 6;
            Console.WriteLine(" ");
        }

       public void ProcesoFOR()
        {
            
            for (int X = 1; X <= Numero; X++)
            {
                Resultado = Resultado * X;
                Console.Write(X + " * ");
            }   
        }

        public void Imprimir()
       {
           Console.WriteLine(" ");
           Console.WriteLine("------------------------------------------");
           Console.WriteLine(" ");
           Console.WriteLine("Factorial de " + Numero + " = " + Resultado);
           Console.WriteLine(" ");
           Console.WriteLine("------------------------------------------");

       }
   
        static void Main(string[] args)
        {
            FACTORIAL figura1 = new FACTORIAL();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            figura1.FactorValor();
            figura1.ProcesoFOR();
            figura1.Imprimir();

            stopWatch.Stop();
            Console.WriteLine("Proceso Finalizado en " +
            stopWatch.Elapsed.ToString(), "Mensaje Sistema");
            Console.ReadKey();
        }
    }
}


