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

         // Создаем новый массив для строк длиной меньше или равной 3 символам
        string[] newArray = new string[originalLength];
        
        int j = 0; // Инициализируем счетчик для нового массива

