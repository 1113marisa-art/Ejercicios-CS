using System;

class Program
{
    static void Main()
    {
        // Matriz: 3 días x 3 productos
        double[,] ventas = new double[3, 3];

        // Entrada de datos
        for (int i = 0; i < 3; i++) // días
        {
            Console.WriteLine("Día " + (i + 1));

            for (int j = 0; j < 3; j++) // productos
            {
                Console.Write("Ingrese la venta del producto " + (j + 1) + ": ");
                ventas[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\n--- TABLA DE VENTAS ---");

        // Encabezado
        Console.WriteLine("        Prod1   Prod2   Prod3");

        // Mostrar tabla
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Día " + (i + 1) + "   ");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(ventas[i, j] + "   ");
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
