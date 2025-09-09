Console.WriteLine("Coloca un numero para saber su factorial");
string numeroUsuario = Console.ReadLine();
int factorial;
bool numero = int.TryParse(numeroUsuario, out factorial);
int resultado = 1;

if (factorial > 0 && numero)
{
    for (int i = factorial; i >= 1; i--)
    {

        resultado *= i;
        Console.WriteLine($"El numero factorial de !{numeroUsuario} es: {resultado}");
    }     
}
else
{
    Console.WriteLine("Tu número debe mayor a 0");
}
