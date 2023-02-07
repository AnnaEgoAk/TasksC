//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int num = 1;
  int length = cube.Length;
  while (num < length){
    cube[num] = Convert.ToInt32(Math.Pow(num, 3));
    num++;
  }
}

void PrintArry(int[] coll){
  int num = coll.Length;
  int index = 1;
  while(index < num){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
