using System;


class MagicNumber
{
    static void Main(string[] args)
    {
        int num = 100000;
        for (; num < 999999; num++)
        {
            bool check2 = CheckNum(num, 2);
            if (check2 == true)
            {
                bool check3 = CheckNum(num, 3);
                if (check3 == true)
                {
                    bool check4 = CheckNum(num, 4);
                    if (check4 == true)
                    {
                        bool check5 = CheckNum(num, 5);
                        if (check5 == true)
                        {
                            bool check6 = CheckNum(num, 6);
                            if (check6 == true)
                            {
                                Console.WriteLine(num);
                                break;
                            }
                        }
                    }
                }
            }
        }
            Console.ReadKey();
        }

    static bool CheckNum(int number, int incr)
    {
        bool arrayEven = false;
        int temp = number * incr;
        string numstring = Convert.ToString(number);
        char[] numarray = numstring.ToCharArray();
        string numstring1 = Convert.ToString(temp);
        char[] numarray1 = numstring1.ToCharArray();
        foreach (char item in numarray)
        {
            char numchar;
            for (int i = 0; i < 6; i++)
            {
                numchar = numarray1[i];
                arrayEven = item.Equals(numchar);
                if (arrayEven == true)
                {
                    break;
                }
            }
            if (arrayEven == false)
            {
                break;
            }
        }
        return arrayEven;
    }
}


