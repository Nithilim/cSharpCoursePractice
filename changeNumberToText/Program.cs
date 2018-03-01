using System;


//Programa teisingai veikia tik su -999 iki 999 vertem. Su vertem iki 19 tukstanciu parodo viska teisingai tik tukstanciu dalies linksnis blogas.
//Su 19 ir didesnem vertem daro klaidas, pameta skaicius. Sitas klaidas, kai turesiu daugiau laiko istaisysiu.
//Taip pat, reikes sudet veiksmai kurie yra apibrezti su inputNum reziais reikes perkelt i funkcijas ir inputNum kintamaji naudot kaip 'ref' kad verte inputNum adrese pakistu.

class Program
{

    static void Main()
    {
        bool num = true;
        bool minus = false;
        int temp = 0;
        int temp1 = 0;
        Console.WriteLine("iveskit skaiciu");
        string input = Console.ReadLine();
        for (int i = 0; (i < input.Length); i++)
        {
            char symbol = input[i];
            minus = checkMinus(symbol, i);
            if (minus == false)
            {
                if (checkNum(symbol) == false)
                {
                    num = false;
                    break;
                }
                else
                {
                    num = true;
                }
            }
            else
            {
                Console.Write("Minus ");
            }
        }
        if (num == false)
        {
            Console.WriteLine("Blogas ivedimas");
        }
        else
        {
            input = input.Trim('-');
            int inputNum = Convert.ToInt32(input);
            if (inputNum < 1000001 && inputNum > 999)
            {
                if (inputNum == 1000000)
                {
                    Console.WriteLine("Milijonas");
                }
                temp = inputNum / 1000;
                if (temp >= 1 && temp < 20)
                {
                    Console.Write(printNum(temp));
                    Console.Write(printNum3(temp));
                    inputNum = inputNum % 1000;
                }
                if (temp > 19 && temp < 100)
                {
                    temp = temp - (temp % 10);
                    Console.Write(printNum1(temp));
                    Console.Write(printNum3(temp));
                    inputNum = inputNum % 1000;
                }
                if (temp > 99 && temp < 1000)
                {
                    temp1 = temp % 100;
                    if (temp1 >= 1 && temp1 < 20)
                    {
                        Console.Write(printNum(temp1));
                    }
                    else
                    {
                        temp1 = temp1 - (temp1 % 10);
                        Console.Write(printNum1(temp1));
                        temp1 = temp - (temp % 100);
                        Console.Write(printNum2(temp1));
                        Console.Write(printNum3(temp));
                    }
                    inputNum = inputNum % 1000;
                }
            }
            if (inputNum < 1000 && inputNum > 99)
            {
                temp = inputNum / 100;
                if (temp > 1)
                {
                    Console.Write(printNum(temp));
                    temp = inputNum % 100;
                    temp = inputNum - temp;
                    Console.Write(printNum2(temp));
                    inputNum = inputNum % 100;
                }
                else
                {
                    temp = inputNum % 100;
                    temp = inputNum - temp;
                    Console.Write(printNum2(temp));
                    inputNum = inputNum % 100;
                }
            }
            if (inputNum < 100 && inputNum > 19)
            {
                temp = inputNum % 10;
                temp = inputNum - temp;
                Console.Write(printNum1(temp));
                inputNum = inputNum % 10;
            }
            temp = inputNum;
            if (inputNum >= 0 && inputNum < 20 && temp > 0)
            {
                Console.Write(printNum(inputNum));

            }

        }
        Console.ReadKey();
    }
    static bool checkMinus(char input, int i)
    {
        bool minus = false;
        if (i == 0)
        {
            if (input == '-')
            {
                minus = true;
            }
        }
        return (minus);
    }
    static bool checkNum(char symbol)
    {
        bool NumResult = false;
        if (symbol != '0' && symbol != '1' && symbol != '2' && symbol != '3' && symbol != '4' && symbol != '5' && symbol != '6' &&
                    symbol != '7' && symbol != '8' && symbol != '9')
        {
            NumResult = false;
        }
        else
        {
            NumResult = true;
        }
        return (NumResult);
    }
    static string printNum(int num)
    {
        string StringNumber = "Perdaug ivesta.";
        if (num < 10)
        {
            switch (num)
            {
                case 0:
                    StringNumber = "nulis";
                    break;
                case 1:
                    StringNumber = "vienas";
                    break;
                case 2:
                    StringNumber = "du";
                    break;
                case 3:
                    StringNumber = "trys";
                    break;
                case 4:
                    StringNumber = "keturi";
                    break;
                case 5:
                    StringNumber = "penki";
                    break;
                case 6:
                    StringNumber = "sesi";
                    break;
                case 7:
                    StringNumber = "septyni";
                    break;
                case 8:
                    StringNumber = "astuoni";
                    break;
                case 9:
                    StringNumber = "devyni";
                    break;
            }
        }
        if (num > 9 && num < 20)
        {
            switch (num)
            {
                case 10:
                    StringNumber = "desimt ";
                    break;
                case 11:
                    StringNumber = "vienuolika ";
                    break;
                case 12:
                    StringNumber = "dvylika ";
                    break;
                case 13:
                    StringNumber = "trylika ";
                    break;
                case 14:
                    StringNumber = "keturiolika ";
                    break;
                case 15:
                    StringNumber = "penkiolika ";
                    break;
                case 16:
                    StringNumber = "sesiolika ";
                    break;
                case 17:
                    StringNumber = "septyniolika ";
                    break;
                case 18:
                    StringNumber = "astuoniolika ";
                    break;
                case 19:
                    StringNumber = "devyniolika ";
                    break;
            }
        }
        return (StringNumber);
    }
    static string printNum1(int num)
    {
        string StringNumber = "Perdaug ivesta.";
        if (num > 19 && num < 100)
        {
            switch (num)
            {
                case 20:
                    StringNumber = " dvidesimt ";
                    break;
                case 30:
                    StringNumber = " trisdesimt ";
                    break;
                case 40:
                    StringNumber = " keturiasdesimt ";
                    break;
                case 50:
                    StringNumber = " penkiasdesimt ";
                    break;
                case 60:
                    StringNumber = " sesiasdesimt ";
                    break;
                case 70:
                    StringNumber = " septyniasdesimt ";
                    break;
                case 80:
                    StringNumber = " astuoniasdesimt ";
                    break;
                case 90:
                    StringNumber = " devyniasdesimt ";
                    break;
            }
        }
        return (StringNumber);
    }
    static string printNum2(int num)
    {
        string StringNumber = "Perdaug ivesta.";
        if (num == 100)
        {
            StringNumber = " simtas ";
        }
        else
        {
            StringNumber = " simtai ";
        }
        return (StringNumber);
    }
    static string printNum3(int num)
    {
        string StringNumber = "Perdaug ivesta.";
        if (num == 1)
        {
            StringNumber = " tukstantis ";
        }
        else
        {
            StringNumber = " tukstanciu ";
        }
        return (StringNumber);
    }

}
