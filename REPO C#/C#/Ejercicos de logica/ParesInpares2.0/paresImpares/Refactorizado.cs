using System;
using System.Collections.Generic;
using System.Linq;

class Refactorizado
{
    static void Main()
    {
        Console.WriteLine("Coloca una lista separada por comas, ejemplo: 1,2,35,6,7,8,8,9");

        string listaUsuario = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(listaUsuario))
        {
            Console.WriteLine("La lista no puede ser nula o estar vacía");
            return;
        }

        // Validar y convertir entradas
        if (!TryParseLista(listaUsuario, out List<int> numeros))
        {
            Console.WriteLine("Debes colocar solo números");
            return;
        }

        // Procesar pares e impares
        var (contadorPares, contadorImpares) = ClasificarNumeros(numeros);

        // Mostrar resultados
        MostrarResultados(contadorPares, contadorImpares);
    }

    static bool TryParseLista(string input, out List<int> numeros)
    {
        numeros = new List<int>();
        foreach (string entrada in input.Split(','))
        {
            if (int.TryParse(entrada.Trim(), out int num))
            {
                numeros.Add(num);
            }
            else
            {
                return false; // Si hay un error, detenemos todo
            }
        }
        return true;
    }

    static (Dictionary<int, int> pares, Dictionary<int, int> impares) ClasificarNumeros(List<int> numeros)
    {
        var pares = new Dictionary<int, int>();
        var impares = new Dictionary<int, int>();

        foreach (int num in numeros)
        {
            var dic = (num % 2 == 0) ? pares : impares;

            if (!dic.ContainsKey(num))
                dic[num] = 0;

            dic[num]++;
        }

        return (pares, impares);
    }

    static void MostrarResultados(Dictionary<int, int> pares, Dictionary<int, int> impares)
    {
        Console.WriteLine($"La lista de pares es: {string.Join(", ", pares.Keys)}");
        Console.WriteLine($"La lista de impares es: {string.Join(", ", impares.Keys)}");

        Console.WriteLine("\nFrecuencia de pares:");
        foreach (var kvp in pares)
            Console.WriteLine($"{kvp.Key} aparece {kvp.Value} vez/veces");

        Console.WriteLine("\nFrecuencia de impares:");
        foreach (var kvp in impares)
            Console.WriteLine($"{kvp.Key} aparece {kvp.Value} vez/veces");
    }
}
