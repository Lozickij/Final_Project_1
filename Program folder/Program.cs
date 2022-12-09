/*Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

string[] array1 = new string[] {"Hello", "2", "world", ":-)"};
//string[] array1 = new string[] {"1234", "1567", "-2", "computer science"};
//string[] array1 = new string[] {"Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];
void CreateAnotherArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
ShowArray(array1);
CreateAnotherArray(array1, array2);
Console.Write(" -> ");
ShowArray(array2);