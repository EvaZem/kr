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

        // Проходим по исходному массиву и копируем строки длиной <= 3 в новый массив
        for (int i = 0; i < originalLength; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[j] = originalArray[i];
                j++;
            }
        }
        
        // Выводим новый массив на экран
        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        for (int i = 0; i < j-5; i++)
        {
            Console.WriteLine(newArray[i]);
        }

