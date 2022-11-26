// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}

Console.WriteLine("Введите первое целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
int c = Convert.ToInt32(Console.ReadLine());

int max = Max(a, b, c);
Console.WriteLine($"Максимальное из этих трех чисел {max} ");