double[,] array(int m, int n)
{
    double[,] value = new double[m, n];
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            value[i, j] = new Random().NextDouble() * 100;
        }
    }
    return value;
}

void PrintArray(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j] + "    ");
        }
    }
}

int m = 4;
int n = 2;
double[,] number = array(m, n);
PrintArray(number);