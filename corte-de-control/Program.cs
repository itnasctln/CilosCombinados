using System;

namespace corte_de_control
{
    class Program
    {
        static void Main()
        {
            // Declaramos variables
            int edad, legajo, codigoEquipo;
            float sueldo;
            int equipoActual;
            int contadorJugadores;

            // Ingreso inicial
            Console.WriteLine("Ingrese el legajo:");
            legajo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el sueldo:");
            sueldo = float.Parse(Console.ReadLine());

            // Si el primer sueldo es negativo, corta inmediatamente
            if (sueldo <= 0)
            {
                Console.WriteLine("\nCarga finalizada. Sueldo negativo detectado.");
                return;
            }

            Console.WriteLine("Ingrese el código de Equipo:");
            codigoEquipo = int.Parse(Console.ReadLine());

            // Corte total: sueldo negativo
            while (sueldo > 0)
            {
                equipoActual = codigoEquipo;
                contadorJugadores = 0;

                Console.WriteLine($"\n=== Comienza carga para equipo {equipoActual} ===");

                // Procesamos jugadores del mismo equipo
                while (codigoEquipo == equipoActual && sueldo > 0)
                {
                    // Mostramos jugador
                    Console.WriteLine($"Jugador -> Legajo: {legajo}, Edad: {edad}, Sueldo: {sueldo}");
                    contadorJugadores++;

                    // Ingreso siguiente jugador
                    Console.WriteLine("\nIngrese el legajo:");
                    legajo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la edad:");
                    edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el sueldo:");
                    sueldo = float.Parse(Console.ReadLine());

                    // 💡 Corte inmediato
                    if (sueldo <= 0)
                    {
                        Console.WriteLine($"=== Equipo {equipoActual} finalizado. Se cargaron {contadorJugadores} jugadores ===");
                        Console.WriteLine("\nCarga finalizada. Sueldo negativo detectado.");
                        return; // sale del programa en el acto
                    }

                    Console.WriteLine("Ingrese el código de Equipo:");
                    codigoEquipo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"=== Equipo {equipoActual} finalizado. Se cargaron {contadorJugadores} jugadores ===");
            }
        }
    }
}
