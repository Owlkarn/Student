int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadInt("Введите число: "); 
int[] array = new int[n];

for  (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[j] = i * n + j +1;
        if (array[j] < 10)
        {
            Console.Write(array[j] + "  ");
        }
        else
        {
            Console.Write(array[j] + " ");
        }        
    }
    Console.WriteLine();
}
