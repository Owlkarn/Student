Console.Write("Введите число от 0 до 99 999: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = (int)Math.Log10(number) + 1;


switch (length)
{
    case 5:
        if (number / (int)Math.Pow(10, length - 1) == 1)
        {
            switch(number / (int)Math.Pow(10, length-2) % 10)
            {
                case 9:
                    Console.Write("девятнадцать тысяч ");
                    length = length - 2;
                break;
                
                case 8:
                    Console.Write("восемнадцать тысяч ");
                    length = length - 2;
                break;
                
                case 7:
                    Console.Write("семнадццать тысяч ");
                    length = length - 2;
                break;
                
                case 6:
                    Console.Write("шестнадцать тысяч ");
                    length = length - 2;
                break;
                
                case 5:
                    Console.Write("пятнадцать тысяч ");
                    length = length - 2;
                break;
                
                case 4:
                    Console.Write("четырнадцать тысяч ");
                    length = length - 2;
                break;
                
                case 3:
                    Console.Write("тринадцать тысяч ");
                    length = length - 2;
                break;
                
                case 2:
                    Console.Write("двенадцать тысяч ");
                    length = length - 2;
                break;

                case 1:
                    Console.Write("одиннадцать тысяч ");
                    length = length - 2;
                break;

                case 0:
                    Console.Write("десять тысяч ");
                    length = length - 2;
                break;
            }
        goto case 3;

        }
        else
        {
            switch(number / (int)Math.Pow(10, length - 1) % 10)
        {
            case 9:
                Console.Write("девяносто ");
                length--;
                break;
            case 8:
                Console.Write("восемьдесят ");
                length--;
                break;
            case 7:
                Console.Write("семьдесят ");
                length--;
                break;
            case 6:
                Console.Write("шестьдесят ");
                length--;
                break;
            case 5:
                Console.Write("пятьдесят ");
                length--;
                break;
            case 4:
                Console.Write("сорок ");
                length--;
                break;
            case 3:
                Console.Write("тридцать ");
                length--;
                break;
            case 2:
                Console.Write("двадцать ");
                length--;
                break;
            case 0:
                length--;
                break;
        }
        if (number / (int)Math.Pow(10, length - 1) % 10 == 0) 
        {
            Console.Write("тысяч ");
            length--;
        }
        goto case 4;
        }

    case 4:
        switch(number / (int)Math.Pow(10, length - 1) % 10)
        {
            case 9:
                Console.Write("девять тысяч ");
                length--;
                break;
            case 8:
                Console.Write("восемь тысяч ");
                length--;
                break;
            case 7:
                Console.Write("семь тысяч ");
                length--;
                break;
            case 6:
                Console.Write("шесть тысяч ");
                length--;
                break;
            case 5:
                Console.Write("пять тысяч ");
                length--;
                break;
            case 4:
                Console.Write("четыре тысячи ");
                length--;
                break;
            case 3:
                Console.Write("три тысячи ");
                length--;
                break;
            case 2:
                Console.Write("две тысячи ");
                length--;
                break;
            case 1:
                Console.Write("одна тысяча ");
                length--;
                break;
        }
        goto case 3;

    case 3:
            switch(number / (int)Math.Pow(10, length - 1) % 10)
        {
            case 9:
                Console.Write("девятьсот ");
                length--;
                break;
            case 8:
                Console.Write("восемьсот ");
                length--;
                break;
            case 7:
                Console.Write("семьсот ");
                length--;
                break;
            case 6:
                Console.Write("шестьсот ");
                length--;
                break;
            case 5:
                Console.Write("пятьсот ");
                length--;
                break;
            case 4:
                Console.Write("четыреста ");
                length--;
                break;
            case 3:
                Console.Write("триста ");
                length--;
                break;
            case 2:
                Console.Write("двести ");
                length--;
                break;
            case 1:
                Console.Write("сто ");
                length--;
                break;
            case 0:
                length--;
                break;
        }
        goto case 2;
        

    case 2:
        if (number / (int)Math.Pow(10, length - 1) % 10 == 1)
        {
            switch(number % 10)
            {
                case 9:
                    Console.Write("девятнадцать");
                break;
                
                case 8:
                    Console.Write("восемнадцать");
                break;
                
                case 7:
                    Console.Write("семнадццать");
                break;
                
                case 6:
                    Console.Write("шестнадцать");
                break;
                
                case 5:
                    Console.Write("пятнадцать");
                break;
                
                case 4:
                    Console.Write("четырнадцать");
                break;
                
                case 3:
                    Console.Write("тринадцать");
                break;
                
                case 2:
                    Console.Write("двенадцать");
                break;

                case 1:
                    Console.Write("одиннадцать");
                break;

                case 0:
                    Console.Write("десять");
                break;
            }
        break;
        }
        else
        {
            switch(number / (int)Math.Pow(10, length - 1) % 10)
        {
            case 9:
                Console.Write("девяносто ");
                length--;
                break;
            case 8:
                Console.Write("восемьдесят ");
                length--;
                break;
            case 7:
                Console.Write("семьдесят ");
                length--;
                break;
            case 6:
                Console.Write("шестьдесят ");
                length--;
                break;
            case 5:
                Console.Write("пятьдесят ");
                length--;
                break;
            case 4:
                Console.Write("сорок ");
                length--;
                break;
            case 3:
                Console.Write("тридцать ");
                length--;
                break;
            case 2:
                Console.Write("двадцать ");
                length--;
                break;
            case 0:
                length--;
                break;
        }
        goto case 1;
        }

    case 1:
        switch(number / (int)Math.Pow(10, length - 1) % 10)
        {
            case 9:
                Console.Write("девять");
                break;
            case 8:
                Console.Write("восемь");
                break;
            case 7:
                Console.Write("семь");
                break;
            case 6:
                Console.Write("шесть");
                break;
            case 5:
                Console.Write("пять");
                break;
            case 4:
                Console.Write("четыре");
                break;
            case 3:
                Console.Write("три");
                break;
            case 2:
                Console.Write("два");
                break;
            case 1:
                Console.Write("один");
                break;
        }
    break;

    default:
    if (number == 0)
        {
            Console.Write("ноль");
        }
        else
        {
            Console.Write("Введено число больше 99999");
        }
    break;
}