// See https://aka.ms/new-console-template for more information
List<int> numeros = new List<int> { 13, 0, 0, 0, 50, 7, 1, 3, 5, 6 };
List<int> listaUnicos = new List<int>();
Dictionary<int, int> contadorRepetidos = new Dictionary<int, int>();

foreach (int numero in numeros)
{
    if (!listaUnicos.Contains(numero))
    {
        listaUnicos.Add(numero);
        contadorRepetidos[numero] = 1;
    }
    else
    {
        contadorRepetidos[numero]++;

    }

}
    listaUnicos.Sort();


    int numeroMasRepetitivo =0;
    int maximasRepeticiones =0;

foreach (var kpt in contadorRepetidos)
{
    int numero = kpt.Key;
    int repeticiones = kpt.Value;


    if (repeticiones > maximasRepeticiones)
    {
        maximasRepeticiones = repeticiones;
        numeroMasRepetitivo = numero;
    }
}
// Console.WriteLine($"El número que más se repite es {numeroMasRepetitivo} y aparece {maximasRepeticiones} veces y la lista de menor a mayor es : {listaUnicos}");
Console.WriteLine($"El número que más se repite es {numeroMasRepetitivo} y aparece {maximasRepeticiones} veces y la lista de menor a mayor es: {string.Join(", ", listaUnicos)}");

