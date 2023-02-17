// 4. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Enter new number");
int divider1 = Prompt("Enter first divider");
int divider2 = Prompt("Enter second divider");
if (number % divider1 == 0 & number % divider2 == 0)
{
    System.Console.WriteLine($"{number} is multiple to {divider1} and {divider2} at the same time!");
}
else
{
    System.Console.WriteLine($"{number} is not multiple to {divider1} and {divider2} at the same time.");
}