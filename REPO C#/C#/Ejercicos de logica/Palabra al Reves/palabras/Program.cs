Console.WriteLine("Escribe una palabra para verla alrevés");
string palabra  = Console.ReadLine();

string palabraAlReves = string.Empty;
if (!string.IsNullOrEmpty(palabra))
{
    palabra = palabra.ToUpper();
    for (int i = 0; i < palabra.Length; i++)
    {
        palabraAlReves = palabra[i] + palabraAlReves;

    }
}
else
{
    Console.WriteLine("La palabra no puede ir Nulla o Vacia");
}

string palindromo = (palabra == palabraAlReves) ? "Es palindromo" : "No es palindromo";
Console.WriteLine(palindromo);
