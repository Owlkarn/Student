int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadInt("Введите число: "); 
int[,] mas = new int[n, n];
int i = 0;
int j = 0;
int z = 0;
int g = 0;
int indexI = 0;
int indexJ = 0;

for  (indexI = 0; indexI < n; indexI++)
{
    for (indexJ = 0; indexJ < n; indexJ++)
    {
        mas[indexI, indexJ] = 0;      
    }
}

while (g < n)
{
for  (j = 0; j < n; j++)
{
    i = g;
    if (mas[i,j] == 0)
        {
        mas[i,j] = z + 1;
        z++;  
        }
}
for (i = 0; i < n; i++)
{
    j = n - g - 1;
    if (mas[i,j] == 0)
        {
        mas[i,j] = z + 1; 
        z++;  
        }   
}
for  (j = n - 1; j >= 0; j--)
{
    i = n - g - 1;
    if (mas[i,j] == 0)
        {
        mas[i,j] = z + 1;
        z++;  
        }  
}
for (i = n - 1; i >= 0; i--)
{
    j = g;
    if (mas[i,j] == 0)
        {
        mas[i,j] = z + 1;
        z++;  
        }  
}
g++;
}
i = 0;
j = 0;
for  (i = 0; i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        if (mas[i,j] < 10)
        {
            Console.Write(mas[i,j] + "  ");
        }
        else
        {
            Console.Write(mas[i,j] + " ");
        }        
    }
    Console.WriteLine();
}