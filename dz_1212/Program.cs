using System;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Data;

namespace HW
{
    class Program
    {
        static void calculator()
        {
            int choice = 0;
            string input = "";
            Console.WriteLine("Binary to hex - 1 \n or \nHex to binary - 2");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string: ");
            input = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    string strhex = Convert.ToInt32(input, 2).ToString("X");
                    Console.WriteLine("Hex: " + strhex);
                    break;
                case 2:
                    string binarynumber = Convert.ToString(Convert.ToInt32(input, 16), 2);
                    Console.WriteLine("Binary: " + binarynumber);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        static void texttoint()
        {
            Console.WriteLine("Enter num(0-9): ");
            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
            }
        }
        class ForeignPassport
        {
            public int passportnumber { get; private set; }
            public string pib { get; private set; }
            public DateTime date { get; private set; }

            public ForeignPassport(int passportnumber, string pib, DateTime date)
            {
                if ((passportnumber.ToString()).Length < 1 || (passportnumber.ToString()).Length > 99999) throw new ArgumentOutOfRangeException("passportnumber");
                if (date.Year < 1900) throw new ArgumentOutOfRangeException("date");
                if (pib == null) throw new ArgumentNullException("pib");
                this.passportnumber = passportnumber;
                this.pib = pib;
                this.date = date;
            }

            public void print()
            {
                Console.WriteLine($"Passport number: {passportnumber}");
                Console.WriteLine($"PIB: {pib}");
                Console.WriteLine($"Date: {date}");
            }
        }
        static bool checkstring(string input)
        {
            string[] a = input.Split(' ');
            int one = int.Parse(a[0]);
            int two = int.Parse(a[2]);
            switch (a[1])
            {
                case "==":
                    if (one == two) return true;
                    return false;
                case ">":
                    if (one > two) return true;
                    return false;
                case "<":
                    if (one < two) return true;
                    return false;
                case "!=":
                    if (one != two) return true;
                    return false;
                case ">=":
                    if (one >= two) return true;
                    return false;
                case "<=":
                    if (one <= two) return true;
                    return false;
                default:
                    throw new ArgumentException("Wrong input");
            }
            return true;
        }

        static int Main(string[] args)
        {
            DateTime dt = new DateTime(2000, 1, 1);
            try
            {
                ForeignPassport pass = new ForeignPassport(14562626, "Vova Latusch", dt);
                pass.print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Enter equation");
            string input = Console.ReadLine();
            try
            {
                bool x = checkstring(input);
                Console.WriteLine($"{input} is {x}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return 0;
        }
    }
}
