// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
int num = 99;
int A = 1;
int cub = 1;
while(A < num);
{
    cub = A * A * A;
        if (cub % 2 == 0);
        {
            Console.Write($"{cub} ");
        }
    A++;    
}
