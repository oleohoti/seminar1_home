// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b) 
{
   Console.WriteLine($"число {a} большее, число {b} меньшее");
}
else
{ Console.WriteLine($"число {b} болшее, число {a} меньшее");
}
