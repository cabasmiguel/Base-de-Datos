using System.Text.RegularExpressions;

public class ValidateNumber
{

    public string isNullOrempy(string numberUser)
    {
        if (string.IsNullOrEmpty(numberUser))
        {
            Console.WriteLine("Debes colocar un número para saber su Fibonacci");
            return numberUser;
        }
        else
        {
            return numberUser;
        }
    }

    public bool isNumber(string numberUser)
    {
        int fibonacci;
        bool number = int.TryParse(numberUser, out fibonacci);
        if (fibonacci > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine($"El número colocado no es un número positivo o no es número{numberUser}");
            return number;
        }
    }

    public bool isSpacialCharacter(string numberUser)
    {
    bool hadSpecialCharacter = Regex.IsMatch(numberUser, @"^\d+$");
    if (!hadSpecialCharacter)
    {
        Console.WriteLine("No se permiten caracteres especiales");
    }
    return hadSpecialCharacter;
    }

    public int convertNumber(string numberUser)
    {
        int numberFibonacci = int.Parse(numberUser);
        return numberFibonacci;
    }

    public int fibonacci(int numberFibonacci)
    {

            int a = 0;
            int b = 1;
            int suma = 0;

        for (int i = 0; i < numberFibonacci; i++)
        {
            suma = a + b;
            Console.Write($"F({numberFibonacci}) :{suma} ");
            a = b;
            b = suma;

        }
        return suma;
    }

}