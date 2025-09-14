Console.WriteLine("Coloca un número para saber su Fibonacci");

string numberUser = Console.ReadLine();

ValidateNumber validate = new ValidateNumber();

string validateEmptyOrNull = validate.isNullOrempy(numberUser);
bool validateIsNumer = validate.isNumber(numberUser);
bool specialCharacter = validate.isSpacialCharacter(numberUser);
int convertNumber = validate.convertNumber(numberUser);
int fibonacci = validate.fibonacci(convertNumber);