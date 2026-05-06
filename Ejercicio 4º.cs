using System;

class Program
{
    static void Main()
    {
        // Matriz: 3 participantes x 3 rondas (puedes cambiar tamaños)
        int[,] puntajes = new int[3, 3];
        int mayor;

        // Leer el primer valor y tomarlo como mayor
        Console.Write("Ingrese el puntaje del participante 1, ronda 1: ");
        puntajes[0, 0] = Convert.ToInt32(Console.ReadLine());
        mayor = puntajes[0, 0];

        // Leer el resto de la matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Evitar repetir la primera posición
                if (i == 0 && j == 0) continue;

                Console.Write("Ingrese el puntaje del participante " + (i + 1) + ", ronda " + (j + 1) + ": ");
                puntajes[i, j] = Convert.ToInt32(Console.ReadLine());

                // Comparar para encontrar el mayor
                if (puntajes[i, j] > mayor)
                {
                    mayor = puntajes[i, j];
                }
            }
        }

        // Mostrar resultado
        Console.WriteLine("\nEl puntaje más alto es: " + mayor);

        Console.ReadKey();
    }
}