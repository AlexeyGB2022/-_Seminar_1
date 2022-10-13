Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);

//int M = N * (-1);
int i = 2;

if (N==0) 
{
    Console.Write("0 ");
}


if (N<0) 
{
    i = 0;
    while (i>=N)
    {
        Console.Write(i + " ");
        i = i - 2;
    }
}

if (N>0) 
{
    while (i<=N)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}