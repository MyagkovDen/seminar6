// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int size = GetNumberFromUser("Введите количество чисел: ", "Ошибка ввода!");
int[] array = GetArray(size);
int res = FindPositive(array);

PrintArray(array);
Console.Write($" -> {res}");

//////////////////////////////////////////////////////////////////////////////////////////////////////

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

int FindPositive(int[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] GetArray(int measure)
{
    int[] arr = new int[measure];
    for (int i = 0; i < measure; i++)
    {
        arr[i] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
    }
    return arr;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        else
            Console.WriteLine(errorMessage);
    }
}