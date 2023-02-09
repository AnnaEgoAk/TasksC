// написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1;
int A = 1;

while (A <= num);
{
    count = count * A;
    Console.Write($"{A}" );
    A++;
}
Console.WriteLine($"= {count} ");