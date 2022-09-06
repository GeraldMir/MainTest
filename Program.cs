// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Ввидите элементы массива через ТОЧКУ С ЗАПЯТОЙ И ПРОБЕЛ (; ) ");
const int n = 3;
string[] uzerArray= Console.ReadLine().Split("; ");
string elementsNewArray=null;
Random rnd=new Random();
string temp= Convert.ToString(rnd.Next(1000, 10000));
for (int i = 0; i < uzerArray.Length; i++)
{ 
    if (uzerArray[i].Length<=n)
    {
        elementsNewArray =elementsNewArray+(uzerArray[i]+temp);
    }
}
string[]newArray= elementsNewArray.Split(temp, StringSplitOptions.RemoveEmptyEntries);
Console.Clear();
Console.WriteLine('[' + string.Join(", ", uzerArray) + "] -> " + '[' + string.Join(", ", newArray) + "]");