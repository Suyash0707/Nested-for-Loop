
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Schema;

public class program
{
    public static void Main()
    {
        pattern1();
        pattern2();
        pattern3();
        SetLimit1();
        SetLimit2();
        SetLimit3();
        SetLimit4();
        SetLimit5();
        pattern4();

        static void pattern1()
        {
            for (int i = 1; i <= 5; i++) //prints Rows
            {
                for (int j = 1; j <= 10; j++) //prints columns 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void pattern2()
        {
            for (int i = 1; i <= 7; i++) // 7 Rows
            {
                for (int j = 1; j <= 12; j++) //12 columns
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void pattern3()
        {
            for (int i = 1; i <= 3; i++) //3 rows
            {
                for (int j = 1; j <= 5; j++) // 5 columns....prints 1-5 numbers 3 times in rows.
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void SetLimit1()
        {
            Console.WriteLine("Please Enter Limit");
            string str = Console.ReadLine();
            int limit = Convert.ToInt32(str);

            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        static void SetLimit2()
        {
            Console.WriteLine("Please Enter the Limit");
            string str = Console.ReadLine();
            int limit = Convert.ToInt32(str);

            for (int i = 1; i <= limit; i++)
            {
                for (int j = limit; j >= 1; j--)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

    static void SetLimit3()
        {
            Console.WriteLine("Please Enter the value for Rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the value for columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i <= rows; i++)
            {
                for(int j =1; j <= columns; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

    static void SetLimit4()
        {
            Console.WriteLine("Please Enter the value for Rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the value for columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write(Convert.ToChar(65)); // Ascii value of A=65, B=66...Z=90.  //Ascii value of a=97, b=98...z=122
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

    static void SetLimit5()
        {
            Console.WriteLine("Please Enter the value for Rows"); //prints A B C D in line as per given limit
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the value for columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write("" + Convert.ToChar(64 + j)); // Ascii value of A=65, B=66...Z=90.  //Ascii value of a=97, b=98...z=122
                                                                // 64 + j...increases ascii value and prints char accordingly
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

    static void pattern4()
        {
            int k = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("" + Convert.ToChar(64 + k++)); 
                                                             
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

        }
    }
}