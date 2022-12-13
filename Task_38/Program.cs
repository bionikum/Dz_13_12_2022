// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int max = 0;
int min = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
     if (array[i] > max)
        {
             max = array[i];
             min += max;
        }
        else if (array[i] < min)
        {
            min = array[i];
        }   
}


Console.WriteLine($"Наш массив: [{string.Join(", ", array)}]");
Console.WriteLine($" Min: {min}");
Console.WriteLine($" Max: {max}");
Console.WriteLine(max - min);