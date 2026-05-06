using System;

class Program
{
    static void Main()
    {
        // Matriz: 3 sucursales x 3 meses
        double[,] ventas = new double[3, 3];
        double total = 0;

        // Leer datos
        for (int i = 0; i < 3; i++) // sucursales
        {
            Console.WriteLine("Sucursal " + (i + 1));

            for (int j = 0; j < 3; j++) // meses
            {
                Console.Write("Ingrese ventas del mes " + (j + 1) + ": ");
                ventas[i, j] = Convert.ToDouble(Console.ReadLine());

                total += ventas[i, j]; // acumulación
            }
        }

        // Mostrar total
        Console.WriteLine("\nTotal de ventas de todas las sucursales y meses: " + total);

        Console.ReadKey();
    }
}
