using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        //Pedir en la consola el nombre y edad
        //Mostrar en pantalla el siguiente mensaje "Te llamas + nombre y tienes + edad años"
        static void Main(string[] args)
        {
            String nombre;
            String edad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            edad = Console.ReadLine();
            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años ");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
