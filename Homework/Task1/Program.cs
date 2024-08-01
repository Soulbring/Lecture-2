//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
System.Console.WriteLine("Введите число");
int NumberOne = Convert.ToInt32(System.Console.ReadLine());

if (NumberOne % 7 == 0 && NumberOne % 23 == 0)
{
   System.Console.WriteLine("Число кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Число Не кратно 7 и 23");
}
