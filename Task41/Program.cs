// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputArray(int numM)
{
    int[] arr = new int[numM];
    for (int i = 0; i < numM; i++)
    {
        Console.Write($"Ведите число номер {i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveNumbersCount(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)count++;
    }
    return count;

}

Console.Write("Введите количество чисел: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(numberM);
Console.WriteLine($"Введено чисел больше нуля: {PositiveNumbersCount(array)}");
