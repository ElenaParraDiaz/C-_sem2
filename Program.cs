/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*int Prompt(string msg)
{
Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите трехзначное число");
if (number >= 100 && number < 1000)
{
int mid =(number % 100 - number % 10)/10;
Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
Console.WriteLine("Это число не трехзначное");
*/
/*Напишите программу, которая выводит третью цифру заданного числа.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*int Prompt(string msg)
{

Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Введите число");
int ThirdNum(int num)
{
while (num > 999)
{
num /= 10;
}
return num % 10;
}

bool check(int num)
{
if (num < 100)
return false;
else return true;
}

if (check(num) != true)
Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"Третья цифра числа {num} является {ThirdNum(num)}");
*/
/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int Prompt(string msg)
{
System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int DaysNum = Prompt("Введите число");
string ss = "No";
string check(int number)
{
if (number >= 6 && number < 8) ss = "Yes";
if (number >= 1 && number < 7) ss = "No";
return ss;
}
System.Console.WriteLine(check(DaysNum));