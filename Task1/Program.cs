void PrintArray(string[] array)
    {
        foreach (string str in array)
        {
            Console.WriteLine(str);
        }
    }
        // Инициализируем исходный массив строк
        string[] originalArray = { "sdf", "huk", "qwc", "bvd", "zx", "x" };
        // Печатаем массив
        Console.WriteLine("Изначальный массив:");
        PrintArray(originalArray); 
        
        // Подсчитываем количество строк в исходном массиве
        int originalLength = originalArray.Length;

