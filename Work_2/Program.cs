// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int [] array = {6,4,5};
int n = array.Length;
int find = 2;
int index = 0;
while (index < n)
{
    {if (array [index]==find);
    }
    index++;
}
Console.WriteLine(array[2]);





void PrintArray (int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine (col[position]);
        position++;
    }
}
int indexOf ( int[]array, int find)
{
    int count= array.Length;
    int index =0;
    int position =-1;
    while (index<count)
    {
        if (array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int [] array = {7,8};

PrintArray(array);
Console.WriteLine();

int pos = indexOf(array,444);
Console.WriteLine (pos + "третьей цифры нет");






int [] array = {3,2,6,7,9};
int n = array.Length;
int find = 2;
int index = 0;
while (index < n)
{
    {if (array [index]==find);
    }
    index++;
}
Console.WriteLine(array[2]);
