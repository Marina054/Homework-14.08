// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Введите день недели:...");
string username = Console.ReadLine();

if (username.ToLower() == "1")
{
    Console.WriteLine("Нет");
}
if (username.ToLower() == "2")
{
    Console.WriteLine("Нет");
}
if (username.ToLower() == "3")
{
    Console.WriteLine("Нет");
}
if (username.ToLower() == "4")
{
    Console.WriteLine("Нет");
}
if (username.ToLower() == "5")
{
    Console.WriteLine("Нет");
}
else 
{
    Console.WriteLine("да");
}
