Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = (int)Math.Log10(number) + 1;
int i = 0;
int step = length - 1;

while (i < length)
{
    int chisl = (number / (int)Math.Pow(10, step) % 10);
    Console.Write(chisl + " ");
    i++;
    step--;
}

