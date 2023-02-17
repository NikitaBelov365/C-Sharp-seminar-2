int number = new Random().Next(9, 10000);
int thousandths = number / 1000;
int hundredths = (number - thousandths*1000) / 100;
int tenths = (number - thousandths*1000 - hundredths*100) / 10;
int single = number % 10;


int Max = single;

if (tenths > Max)
{
    Max = tenths;
}
if (hundredths > Max)
{
    Max = hundredths;
}
if(thousandths>Max)
{
    Max = thousandths;
}
System.Console.WriteLine($"{Max} is the biggest digit in {number}");
System.Console.WriteLine($"{thousandths}, {hundredths}, {tenths}, {single}");