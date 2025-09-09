// See https://aka.ms/new-console-template for more information
/*
Pide al usuario que ingrese una lista de números enteros (puedes usar un arreglo o List<int>).

Recorre la lista y:
Cuenta cuántos números son pares.
Cuenta cuántos números son impares.


Crea dos listas separadas: una con los pares y otra con los impares.

Imprime:
La lista de pares y cuántos hay.
La lista de impares y cuántos hay.
*/
Console.WriteLine("Coloca tu lista de números separados por comas, ejemplo: 1,4,5,6");
string input = Console.ReadLine();


List<int> listaParesImpares = input.Split(',').Select(n => int.Parse(n)).ToList();
List<int> listaPares = new List<int>();
List<int> listaImpares = new List<int>();
Dictionary<int, int> contadorPares = new Dictionary<int, int>();
Dictionary<int,int> contadorImpares = new Dictionary<int,int>();

foreach (int numeros in listaParesImpares)
{
    if (numeros % 2 == 0)
    {
        if (!listaPares.Contains(numeros))
        {
        listaPares.Add(numeros);
        contadorPares[numeros] = 1;
        }
        else
        {
        contadorPares[numeros]++;
        }
    }
    else
     { if (!listaImpares.Contains(numeros))
        {
            listaImpares.Add(numeros);
            contadorImpares[numeros] = 1;
        }
        else
        {
         contadorImpares[numeros]++;
        }
        

     }
}
Console.WriteLine($"Los numeros pares son: {string.Join(", ", listaPares)} y los impares son:{string.Join(", ", listaImpares)} ");
Console.WriteLine($"LA cantidad de pares son: {listaPares.Count} y la de impares son {listaImpares.Count}");

