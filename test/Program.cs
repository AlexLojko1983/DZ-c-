/*
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, 
что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string [] CreationArr()
{
    string [] arr = Array.Empty<string>();
    bool a = false;
    while(a == false)
    {  
        int i = 0;               
        Console.Write($"Input arr[i]: ");
        string arr_i = Console.ReadLine();            
        arr = arr.Append(arr_i).ToArray();          
        Console.WriteLine($"another element?[Yes/No] ");
        string b = Console.ReadLine();
        if(b == "N" || b == "No" || b == "n" || b == "no")
        {
            a = true;
        }
        i++;
    }
    return arr; 
}

string [] FindElArr(string [] arr)
{
    string [] newarr = Array.Empty<string>();
    foreach(string el in arr)
    {
        if(el.Length < 4)
        {
            newarr = newarr.Append(el).ToArray();
        }
    }
    return newarr;
}

void NewArr(string [] arr)
{    
    string [] newarr = Array.Empty<string>();
    if (arr.Length < 1)
    {    
        string [] arr1 = CreationArr();
        System.Console.WriteLine($"[{string.Join(", ", arr1)}]");
        newarr = FindElArr(arr1);               
    }
    else
    {
        System.Console.WriteLine($"[{string.Join(", ", arr)}]"); 
        newarr = FindElArr(arr);
    }
    System.Console.WriteLine($"newarr = [{string.Join(", ", newarr)}]");
}

string [] arr = Array.Empty<string>();
// string [] arr = new string[] {"Hello", "2", "world", ":-)"};
NewArr(arr);