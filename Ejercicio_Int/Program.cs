using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        //Para comentar CONTROL + K + C para descomentar CONTROL + K + U
        //Paso 1. Crear 3 variables de tipo INT y asignarles valores esteticos
        //Paso 2. Crear una variable de tipo int la cual guardara la suma de las 3 variables anteriores
        //Paso 3. Mostrar en pantalla el valor de SUMA, con el siguiente mensaje "El valor de SUMA es: " <suma>
        static void Main(string[] args)
        {
            //(paso 1)
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
           //( paso2)
            int suma = numero_1 + numero_2 + numero_3;
           //(paso 3)
            Console.WriteLine("El valor de la suma es:" + suma);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
