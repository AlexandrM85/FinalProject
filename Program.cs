    // Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.
    
    string[] array = {"hello", "2", "world", ":-)"};
    string[] result = new string[array.Length];
    int count = 0;

    void ArrayComparison(string[] array, string[] result)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[count] = array[i];
                count++;
            }
        }
    }

    void PrintArray(string[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] is not null)
            {
                Console.Write($"{result[i]}, ");
            }
        }
        Console.WriteLine();
    }

    ArrayComparison(array, result);
    PrintArray(result);