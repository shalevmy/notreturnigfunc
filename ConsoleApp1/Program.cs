using System;

class HomeworkAssignment2
{
    static void Main()
    {
       Targil8();
    }

    static void Targil1()
    {
        int n = int.Parse(Console.ReadLine());
        PrintReverse(n - 1);
        PrintReverse(n);
        PrintReverse(n + 1);
    }

    static void PrintReverse(int num)
    {
        int rev = 0;
        int temp = num;
        while (temp > 0)
        {
            rev = rev * 10 + (temp % 10);
            temp /= 10;
        }
        Console.WriteLine(rev);
    }

    static void Targil2()
    {
        int tileSize = int.Parse(Console.ReadLine());
        int roomsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < roomsCount; i++)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            CalculateTiles(tileSize, length, width);
        }
    }

    static void CalculateTiles(int sizeCm, double lM, double wM)
    {
        double areaRoom = lM * wM * 10000;
        double areaTile = sizeCm * sizeCm;
        double total = Math.Ceiling(areaRoom / areaTile);
        Console.WriteLine(total);
    }

    static void Targil3()
    {
        int validCount = 0, invalidCount = 0, sum = 0;
        int grade = int.Parse(Console.ReadLine());

        while (grade != 999)
        {
            if (IsValid(grade))
            {
                validCount++;
                sum += grade;
            }
            else
            {
                invalidCount++;
            }
            grade = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(validCount);
        if (validCount > 0) Console.WriteLine((double)sum / validCount);
        Console.WriteLine(invalidCount);
    }

    static bool IsValid(int g)
    {
        if (g >= 0 && g <= 100) return true;
        Console.WriteLine("Invalid Grade");
        return false;
    }

    static void Targil4()
    {
        double l = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());

        PrintRectData(l, w);
        PrintRectData(l * 2, w);
        PrintRectData(l, w / 3);
    }

    static void PrintRectData(double l, double w)
    {
        Console.WriteLine(l * w);
        Console.WriteLine(2 * (l + w));
        Console.WriteLine(Math.Sqrt(l * l + w * w));
    }

    static void Targil6()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 9; i++)
        {
            Console.Write("Digit " + i + ": ");
            PrintDigitPositions(num, i);
        }
    }

    static void PrintDigitPositions(int num, int digit)
    {
        string s = num.ToString();
        bool found = false;
        for (int i = 0; i < s.Length; i++)
        {
            if ((s[i] - '0') == digit)
            {
                Console.Write((i + 1) + " ");
                found = true;
            }
        }
        if (!found) Console.Write("0");
        Console.WriteLine();
    }

    static void Targil7()
    {
        int num = int.Parse(Console.ReadLine());
        ProcessDivisors(num);
    }

    static void ProcessDivisors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " ");
                count++;
            }
        }
        Console.WriteLine("\nCount: " + count);
    }

    static void Targil8()
    {
        for (int i = 0; i < 100; i++)
        {
            int auth = int.Parse(Console.ReadLine());
            Console.WriteLine(GetUpdatedAuth(auth));
        }
    }

    static int GetUpdatedAuth(int n)
    {
        int current = n;
        for (int i = 0; i < 2; i++)
        {
            int lsd = current % 10;
            int msd = int.Parse(current.ToString().Substring(0, 1));
            int checkDigit = (lsd + msd) % 10;
            current = current * 10 + checkDigit;
        }
        return current;
    }
}