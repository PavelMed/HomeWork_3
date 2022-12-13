// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Input a five-digit number: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
{
Console.WriteLine($"The number {number} is a palindrome.");
}
else Console.WriteLine($"The number {number} is not a palindrome");
}
    if (number!.Length == 5)
{
CheckingNumber(number);
}
else Console.WriteLine($"It`s not a five-digit number");
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Input X-coordinate of the A point: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y-coordinate of the A point: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z-coordinate of the A point: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input X-coordinate of the B point: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y-coordinate of the B point: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z-coordinate of the B point:");
double zb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками = {distance}");

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadInt("Enter a number: ");
int ReadInt(string message)
{
 Console.WriteLine(message);
 return Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= number; i++)
{
 Console.WriteLine($"{i * i * i}, ");
}
