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
            //definimos variables
            int n1, suma;
            //variable suma en 0
            suma = 0;
            //solicitamos el ´primer número para que no haya error más abajo
            Console.WriteLine("Ingrese un número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            //while repite la acción hasta que el número ingresado sea 0
            while (n1!=0)
            {
                suma = suma + n1;
                Console.WriteLine("Ingrese un número:");
                n1= Convert.ToInt32(Console.ReadLine());
            }
            //muestra la suma de todos los valores
            Console.WriteLine("La suma de todos los valores es: "+suma);
        }
    }
}
