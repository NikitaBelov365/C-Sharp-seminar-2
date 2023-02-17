// 3. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деление.

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return true;
    }
    System.Console.WriteLine("First number must be bigger than second.\nRestarting.");
    return false;
}
int firstNumber = Prompt("Input first number");
int secondNumber = Prompt("Input second number");

if (Validate(firstNumber, secondNumber))
{
    int remainder = firstNumber % secondNumber;
    if (remainder == 0)
    {
        System.Console.WriteLine($"The {firstNumber} is a multiple of the {secondNumber}");
    }
    else
    {
        System.Console.WriteLine($"The {firstNumber} is not a multiple of the {secondNumber}\nRemainder of a division is {remainder}");
    }
}

