/*                               Задача:
Написать программу, которая из имеющегося массива строк формирует массив 
из строк, длина которых меньше либо равна 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Пример:
["hello", "2", "world", "123"]->["2", "123"]     */

void PrintArray(string[] array)  // вывод существующего массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"{(i != array.Length - 1 ? ", " : "")}");
    }
    Console.Write("]");
}

void GeneratedAarray(string[] array) // формирует массив из строк, длина которых <=3 символам.
{
    Console.Write("->[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"\"{array[i]}\"{(i != array.Length - 1 ? ", " : "")}");
        }
    }
    Console.Write("]");
}

string[] array = { "hello", "2", "world", "123" };

PrintArray(array);
GeneratedAarray(array);