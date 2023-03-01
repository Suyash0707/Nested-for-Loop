
using System.Security.Cryptography;
using System.Xml.Schema;

public class program
{
    public static void Main()
    {
        pattern1();
        pattern2();
        pattern3();

    static void pattern1()
        {
            for(int i = 1; i <= 5; i++) //prints Rows
            {
                for(int j = 1; j <= 10; j++) //prints columns 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

    static void pattern2()
        {
            for(int i = 1; i <= 7; i++) // 7 Rows
            {
                for(int j=1;j<=12; j++) //12 columns
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

    static void pattern3()
        {
            for(int i=1; i<=3; i++) //3 rows
            {
                for(int j=1;j<=5; j++) // 5 columns....prints 1-5 numbers 3 times in rows.
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }
    }
}
