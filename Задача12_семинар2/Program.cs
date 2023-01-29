// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Clear();

 int first = new Random().Next(1,100);
 int second = new Random().Next(1,100);
 int ost = first % second;
if (ost == 0) Console.WriteLine($"Число {first} кратное {second}");
else Console.WriteLine($"Остаток от деления {ost}");


