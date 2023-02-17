// 2. Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(9, 100);

int firstDigit = number / 10;
int secondDigit = number % 10;

int Max = firstDigit;
if(secondDigit>Max)
{
    Max=secondDigit;
}
System.Console.WriteLine($"Biggest digit from {number} is {Max}");