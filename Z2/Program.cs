Console.WriteLine("Введите первое число");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
double numberB = double.Parse(Console.ReadLine()!);

if (numberA==numberB)
{
Console.WriteLine("Числа равны");
Console.WriteLine("Max = " + numberA);
}

if (numberA>numberB)
{
Console.WriteLine("Max = " + numberA);
}

if (numberB>numberA)
{
Console.WriteLine("Max = " + numberB); 
}
