//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

System.Console.WriteLine("Введите двузначное число");
int number = Convert.ToInt32(Console.ReadLine());

int FirstDigit= number % 10;
int SecondDigit= number / 10;

if (number > 9 && number < 100)
{
    if (FirstDigit > SecondDigit)
    {
        System.Console.WriteLine($"Первая цифра больше и это {FirstDigit}");
    }
    else if (SecondDigit > FirstDigit)
    {
        System.Console.WriteLine($"Вторая цифра больше и это {SecondDigit}");
    }
    else
    {
        System.Console.WriteLine("Числа равны");
    }
    
}
else
    {
        System.Console.WriteLine("Вы ввели не двузначное число");
    }