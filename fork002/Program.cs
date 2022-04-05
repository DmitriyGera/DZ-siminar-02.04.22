int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
int find = 3; //Число которое ищем.
int n = 0;
bool f = false;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (find == arr[i, j]) {n = j; f = true; };
        Console.Write("{0}\t", arr[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if (f)
    Console.WriteLine($"Число найдено: столбец {n + 1} ");
else
    Console.WriteLine("Число не найдено");

