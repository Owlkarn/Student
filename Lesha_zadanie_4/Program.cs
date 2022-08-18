void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                int min = array[j];
                array[j] = array[i];
                array[i] = min;
            }
        }
    }
}

int[] mas = {4, 3, 6, 1, 8, 9, 0, 2};

PrintArray(mas);
SortArray(mas);
PrintArray(mas);
