using System;

class Program
{
    static void Main()
    {
        // Matriz: 3 pacientes x 3 registros (puedes cambiar tamaños)
        double[,] temperaturas = new double[3, 3];
        double menor;

        // Leer el primer valor y tomarlo como menor
        Console.Write("Ingrese la temperatura del paciente 1, registro 1: ");
        temperaturas[0, 0] = Convert.ToDouble(Console.ReadLine());
        menor = temperaturas[0, 0];

        // Leer el resto de la matriz
        for (int i = 0; i < 3; i++) // pacientes
        {
            for (int j = 0; j < 3; j++) // registros
            {
                // Evitar repetir la primera posición
                if (i == 0 && j == 0) continue;

                Console.Write("Ingrese la temperatura del paciente " + (i + 1) +
                              ", registro " + (j + 1) + ": ");
                temperaturas[i, j] = Convert.ToDouble(Console.ReadLine());

                // Comparar para encontrar el menor
                if (temperaturas[i, j] < menor)
                {
                    menor = temperaturas[i, j];
                }
            }
        }

        // Mostrar resultado
        Console.WriteLine("\nLa temperatura más baja es: " + menor);

        Console.ReadKey();
    }
}
