using System;


class Program
{
    static void Main()
    {
        findMagicNumber();
        //printMineSweeperNumbers();
    }

    private static void findMagicNumber()
    {
        bool checkmas = false;

        int num;
        for (num = 100000; num < 999999; num++)
        {
            int temp = num * 2;
            string numstring = Convert.ToString(num);
            char[] numarray = numstring.ToCharArray();
            string numstring1 = Convert.ToString(temp);
            char[] numarray1 = numstring1.ToCharArray();
            foreach (char item in numarray)
            {
                char numchar;
                for (int i = 0; i < 6; i++)
                {
                    numchar = numarray1[i];
                    checkmas = item.Equals(numchar);
                    if (checkmas == true)
                    {
                        break;
                    }
                }
                if (checkmas == false)
                {
                    Console.WriteLine("skaiciai nelygus");
                    break;
                }
            }
            if (checkmas == true && temp == num * 2)
            {
                temp = num * 3;
                numstring1 = Convert.ToString(temp);
                numarray1 = numstring1.ToCharArray();
                foreach (char item in numarray)
                {
                    char numchar;
                    for (int i = 0; i < 6; i++)
                    {
                        numchar = numarray1[i];
                        checkmas = item.Equals(numchar);
                        if (checkmas == true)
                        {
                            break;
                        }
                    }
                    if (checkmas == false)
                    {
                        Console.WriteLine("skaiciai nelygus");
                        break;
                    }
                }
            }
        }
        Console.WriteLine(num);
        Console.ReadKey();
    }

    /*
    private static void printMineSweeperNumbers()
    {
        throw new NotImplementedException("TODO: Sukurkite programą kuri liepia vartotojui įvesti MineSweeper žaidimo lauko duomenis. " +
            "Tada paskaičiuoja ir išspausdina lentelę su skaičiais kiek aplinkui(8 kryptyse įskaitant įstrižai) yra minų.");
    }
    */


}

