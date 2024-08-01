//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int n =number;
if(n>10)
{
    while (n>0)
    {
        int remains = n % 10;
        System.Console.Write(remains + ", ");
        n /=10;
    }
}
else
{
    System.Console.WriteLine(number);
}