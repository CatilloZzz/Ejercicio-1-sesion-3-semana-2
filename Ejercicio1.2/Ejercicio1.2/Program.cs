using System;

class RepartoDeGastos
{
    static void Main()
    {

        Console.WriteLine("--- Calculadora de Gastos de Viaje  ---");

        // Pedimos al usuario que ingrese el costo total del viaje.
        Console.Write("Por favor, ingrese el costo total del viaje (C$): ");
        // Guardamos el costo total en una variable de tipo double.
        double costoTotal = Convert.ToDouble(Console.ReadLine());

        // Pedimos al usuario el número de participantes.
        Console.Write("Ingrese el número total de participantes: ");
        // Guardamos la cantidad de participantes en una variable de tipo entero.
        int numeroParticipantes = Convert.ToInt32(Console.ReadLine());

        // Antes de dividir, verificamos que el número de participantes sea mayor que 0.
        if (numeroParticipantes > 0)
        {
            // Si hay al menos un participante, calculamos el costo por persona.
            double costoPorPersona = costoTotal / numeroParticipantes;
            // Mostramos el resultado con formato de dos decimales.
            Console.WriteLine($"\n--> A cada participante le toca pagar: C${costoPorPersona:N2}");
        }
        else
        {
            // Si no hay participantes (o el número es menor a 0), mostramos un mensaje de error.
            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("ERROR: No hay participantes confirmados. Actualice la lista antes de calcular.");
            Console.WriteLine("---------------------------------------------------------------------");
        }

        // Mensaje final indicando que el programa terminó.
        Console.WriteLine("\nCálculo finalizado. Presione cualquier tecla para salir.");
        // Esperamos que el usuario presione una tecla para cerrar el programa.
        Console.ReadKey();
    }
}