
//ciclos combinados

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
class Program

{
    static void Main()
    {
        // for con for

        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine("Ciclo Padre: " + i);
        //     for (int j = 1; j <= 2; j++)
        //     {
        //         Console.WriteLine("  Ciclo hijo: " + j);
        //     }
        // }


        // int n;          // para cada edad ingresada

        // int prom;       // promedio

        // int suma = 0;   // acumulador

        // //20 personas conforman un grupo
        // for (int r = 1; r <= 20; r++)
        // {
        //     Console.WriteLine("Ingrese la edad de la persona " + r + ": ");
        //     n = int.Parse(Console.ReadLine());

        //     suma += n; // sumamos cada edad
        // }


        // //sacamos promedio
        // prom = suma / 20;

        // Console.WriteLine("El promedio de edades es: " + prom);



        //PARA CARGAR MUCHOS GRUPOS DE 11 PERSONAS.



        //  int n;          // para cada edad ingresada

        //  int prom;       // promedio

        //  int suma = 0;   // acumulador

        // int grupos; // cantidad de grupos a cargar
        // Console.WriteLine("Ingrese la cantidad de grupos a cargar: ");
        // grupos = int.Parse(Console.ReadLine()); 


        // for (int g = 1; g <= grupos; g++) // ciclo para cada grupo
        // {
        //     suma = 0; // reiniciamos el acumulador para cada grupo

        //     for (int r = 1; r <= 11; r++) // ciclo para cada persona del grupo
        //     {
        //         Console.WriteLine("Ingrese la edad de la persona " + r + " del grupo " + g + ": ");
        //         n = int.Parse(Console.ReadLine());

        //         suma += n; // sumamos cada edad
        //     }

        //     //sacamos promedio
        //     prom = suma / 11;

        //     Console.WriteLine("El promedio de edades del grupo " + g + " es: " + prom);
        // }



        // FOR CON WHILE
        // vamos a cargar 10 grupos, pero no sabemos cuantas personas tiene cada grupo.
        // haremos un for para los 10 grupos, y mediante un while cargaremos personas.
        //cuando no carguemos mas personas, presionamos 0

        int n;          // para cada edad ingresada
        int prom;       // promedio
        int suma = 0;   // acumulador
        int grupos = 10; // cantidad fija de grupos a cargar

        for (int g = 1; g <= grupos; g++) // ciclo para cada grupo
        {
            suma = 0; // reiniciamos el acumulador para cada grupo
            int r = 0; // contador de personas por grupo

            Console.WriteLine("Cargando grupo " + g + ". Ingrese las edades de las personas (0 para terminar):");

            while (true) // ciclo para cargar personas hasta que se ingrese 0
            {
                Console.Write("Edad de la persona " + (r + 1) + ": ");
                n = int.Parse(Console.ReadLine());

                if (n == 0) // condición de salida
                {
                    break;
                }

                suma += n; // sumamos cada edad
                r++; // incrementamos el contador de personas
            }

            if (r > 0) // evitamos división por cero
            {
                prom = suma / r; // calculamos el promedio
                Console.WriteLine("El promedio de edades del grupo " + g + " es: " + prom);
            }
            else
            {
                Console.WriteLine("No se ingresaron edades para el grupo " + g + ".");
            }
        }
           

    }
}