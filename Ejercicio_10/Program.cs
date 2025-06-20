using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, suma;
            suma = 0;
            Console.WriteLine("Ingrese un número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            suma = suma + n1;
            while (n1!=0)
            {
                Console.WriteLine("Ingrese un número:");
                n1= Convert.ToInt32(Console.ReadLine());
                suma = suma + n1;
            }
            Console.WriteLine("La suma de todos los valores es: "+suma);
        }
    }
}
