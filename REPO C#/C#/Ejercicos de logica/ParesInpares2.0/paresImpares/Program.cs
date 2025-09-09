Console.WriteLine("Coloca una lista separadas por comas ejemplo 1,2,35,6,7,8,8,9");

string listaUsuario = Console.ReadLine();
List<int> listaPares = new List<int>();
List<int> listaImpares = new List<int>();
Dictionary<int, int> contadorPares = new Dictionary<int, int>();
Dictionary<int,int> contadorImpares = new Dictionary<int,int>();

if (!string.IsNullOrEmpty(listaUsuario))
{
    string[] entradas = listaUsuario.Split(',');
    foreach (string entrada in entradas)
    {
        int numeros;
        bool esNumero = int.TryParse(entrada, out numeros);
        if (!esNumero)
        {
            Console.WriteLine("Debes colocar solo números");
            return;
        }
        else
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
            {
                if (!listaImpares.Contains(numeros))
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

       
    }
    Console.WriteLine($"La lista de los pares son: {string.Join(", ", listaPares)} y la de los impares son: {string.Join(", ", listaImpares)}");
        
}
else
{
    Console.WriteLine("La lista no puede ser nulla o estar vacia");
}

