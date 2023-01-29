// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
Console.Clear();

 Console.WriteLine("введите число");

 int a = int.Parse(Console.ReadLine());
 if (( a % 7 == 0)&&( a % 23 ==0))
 {
    Console.WriteLine("Да");
 }
else 
{
    Console.WriteLine("нет");

}
