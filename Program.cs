// Задача 6: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] mas(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input number {i+1} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Positive(int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i]>0)
         count++;
    return count;
}

Console.Write("How many number you want Input: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = mas(size);
ShowArray(myArray);
Console.WriteLine($"Answer is {Positive(myArray)}");

