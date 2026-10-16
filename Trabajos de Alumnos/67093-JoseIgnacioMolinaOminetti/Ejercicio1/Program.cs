// Ejercicio 1: Sistema de Inventario y Durabilidad de Armas
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] armas = { "Arco", "Hacha", "Espada", "Daga" };
        int[] durabilidad = new int[4];

        Console.WriteLine("=== INVENTARIO DE ARMAS ===");

        // 1. Carga de durabilidad con for
        for (int i = 0; i < armas.Length; i++)
        {
            Console.Write("Durabilidad de " + armas[i] + ": ");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        // 2. Menú
        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1: Inspeccionar armas críticas");
        Console.WriteLine("2: Ver arsenal completo");
        Console.Write("Seleccione opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\n[ARMAS CRITICAS]");
                for (int i = 0; i < armas.Length; i++)
                {
                    if (durabilidad[i] <= 20)
                    {
                        Console.WriteLine("¡ALERTA! " + armas[i] + " está por romperse (" + durabilidad[i] + ").");
                    }
                    else
                    {
                        Console.WriteLine(armas[i] + " en buen estado (" + durabilidad[i] + ").");
                    }
                }
                break;

            case 2:
                Console.WriteLine("\n[ARSENAL COMPLETO]");
                for (int i = 0; i < armas.Length; i++)
                {
                    Console.WriteLine(armas[i] + " -> Durabilidad: " + durabilidad[i]);
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.ReadKey();
    }
}
