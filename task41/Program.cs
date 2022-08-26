// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите количество чисел: ");
int size = Convert.ToInt32 (Console.ReadLine ());

int [] array = new int [size];
int i = 0;
for (i = 0; i < array.Length; i++)
{
    Console.WriteLine ("Введите элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write (string.Join(", ", array));
int count = 0;
for (i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine ($"В массиве {count} положительных чисел");

