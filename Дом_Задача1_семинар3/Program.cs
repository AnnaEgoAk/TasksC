// Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine()!);
int Sum = 0;
while(numA > 0); 
{
    Sum = Sum + numA % 10;
    numA = numA % 10;
}
Console.WriteLine(Sum);