
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

        int prom, n, acu, con;
        
        Console.WriteLine("ingrtese 1 para comenzar a procesar o 0 para terminar ");
        n = int.Parse(Console.ReadLine());

        while (nameof != 0) { }
        Acu = 0
            for (int x = 0, x < 20, x++) {
            Console.WriteLine("ingrese la edad");
            n = int.Parse(Console.ReadLine());
            acu += n;

        }
        prom = acu / 20;
        Console.WriteLine("el promedio es" + prom);
    
    }
}