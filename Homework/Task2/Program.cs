//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите первую координату");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите вторую координату");
int y = Convert.ToInt32(System.Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находиться в первой четверти");
}

else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находиться во второй четверти");
}

else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находиться в третьей плоскости");
}

else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находиться в четвертой плоскости");
}

else
{
    System.Console.WriteLine("Точка в центре");
}