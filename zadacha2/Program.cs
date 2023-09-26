// Напишите программу, которая на вход 
// принимает два числа и проверяет, является ли 
// 
// первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a < b)
{
    Console.WriteLine("<");
}
else if(a > b)
{
    Console.WriteLine(">");

}
else
{
    Console.WriteLine("=");
}*/
// Console.WriteLine(Match.Pow(5, 3)) возведение числа в степень 5 в 3 степени