int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadInt("Введите число: "); 
int[] array = new int[n];
array[0] = 1;

for  (int i = 0; i < n; i++)
{
    Console.Write(array[i]);
}
