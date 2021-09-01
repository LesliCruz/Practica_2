using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {

        //En la solucion con el nombre Practica_2, agregar un proyecto de tipo consola con el nombre de
        //CalculoPerimetro.
        //Declarar las variables necesarias para mostrar en pantalla el calculo del perimeto del triangulo
        //Mostrar en pantalla el valor del perimetro, con el siguiente mensaje "El perimetro del triangulo es: "
        static void Main(string[] args)
        {
            //(paso 1)
            int a = 10;
            int b = 10;
            int c = 7;
            //( paso2)
            int p = a + b + c;
            //(paso 3)
            Console.WriteLine("El perimetro del triangulo es:" + p);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
