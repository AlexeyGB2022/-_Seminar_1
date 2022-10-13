Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
double numberC = double.Parse(Console.ReadLine()!);

double max = numberA;

if (numberB>max)
{
max = numberB;
}

if (max>numberC)
{
Console.WriteLine("Max = " + max);
}

else
{
Console.WriteLine("Max = " + numberC);
}

