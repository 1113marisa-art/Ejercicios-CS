using System;

class Program
{
    static void Main()
    {
        // Matriz de 3 estudiantes x 3 asignaturas
        double[,] notas = new double[3, 3];

        // Entrada de datos
        for (int i = 0; i < 3; i++) // estudiantes
        {
            Console.WriteLine("Estudiante " + (i + 1));

            for (int j = 0; j < 3; j++) // asignaturas
            {
                Console.Write("Ingrese la nota de la asignatura " + (j + 1) + ": ");
                notas[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\n--- Notas Registradas ---");

        // Mostrar datos organizados
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Estudiante " + (i + 1) + ": ");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(notas[i, j] + " ");
            }

            Console.WriteLine(); // salto de línea por estudiante
        }

        Console.ReadKey();
    }
}
