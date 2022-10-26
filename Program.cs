//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void Palindrome (int number)
{
    if(number / 100000 == 0 && number > 10000)
        {
            if(number / 10000 == number % 10)
                if((number / 1000) % 10 == (number % 100) / 10)
                    Console.WriteLine("It is a palindrome");
                else Console.WriteLine("It is not a palindrome");
            else Console.WriteLine("It is not palindrome");
        }
else Console.WriteLine("it is not five digit number");
}
Console.Write("Input five-digit number: ");
int result = Convert.ToInt32(Console.ReadLine());
Palindrome(result);
*/
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double catet1 = x1 - x2;
    double catet2 = y1 - y2;
    double catet3 = z1 - z2;
    double result = Math.Sqrt(catet1*catet1 + catet2*catet2 + catet3*catet3);
    return result;
}
Console.WriteLine("Input coordinates x1: ");
double result1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates y1: ");
double result2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates z1: ");
double result3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates x2: ");
double result4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates y2: ");
double result5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates z2: ");
double result6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ответ: {Distance(result1, result2, result3, result4, result5, result6)} ");
*/
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void Table( int number)
{
     int index = 1;
     while (index <= number)
     {
        double result = Math.Pow(index, 3);
        Console.Write(result + " ");
        index++;
     }
}
Console.Write("Input number: ");
int result = Convert.ToInt32(Console.ReadLine());
Table(result);
*/