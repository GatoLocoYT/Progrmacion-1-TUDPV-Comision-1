// Ejercicio 2: Marcador Top 5 de Speedrun
// Nota: en esta versión los tiempos se vuelven a cargar en cada consulta.
// La consigna original pide cargarlos una sola vez (for de carga afuera del while).
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        float[] tiempos = new float[5];
        int seguir = 1;

        Console.WriteLine("=== MARCADOR TOP 5 DE SPEEDRUN ===");

        while (seguir == 1)
        {
            // 1. Carga de los 5 tiempos (decimales con coma, ej. 45,7)
            Console.WriteLine("\n--- Carga de tiempos ---");
            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write("Tiempo del corredor " + (i + 1) + " (segundos): ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }

            // 2. Tiempo objetivo
            Console.Write("\nIngrese el tiempo objetivo: ");
            float objetivo = float.Parse(Console.ReadLine());

            // 3. Clasificación
            int clasificados = 0;
            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] <= objetivo)
                {
                    Console.WriteLine("Corredor " + (i + 1) + " CLASIFICA (" + tiempos[i] + " s)");
                    clasificados++;
                }
                else
                {
                    Console.WriteLine("Corredor " + (i + 1) + " no clasifica (" + tiempos[i] + " s)");
                }
            }
            Console.WriteLine("Total de clasificados: " + clasificados);

            // 4. ¿Repetir?
            Console.Write("\n¿Otra consulta? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta != "S")
            {
                seguir = 0;
            }
        }

        Console.WriteLine("\nFin del marcador.");
        Console.ReadKey();
    }
}
