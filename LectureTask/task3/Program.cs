//int n = 10;
int[] array = { 2, 5, 8, 13, 45, 25, 36, 20, 80, 12 };
int i = 0;
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}