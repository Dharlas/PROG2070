/*Kenneth Gering
 * Assignment 2
 * PROG2070
 *Revision Date:
 * Feb.28/20 project started
 */
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = 0;
            int sideB = 0;
            int sideC = 0;
            int menuOption = 0;

            do
            {
                do
                {
                    Console.WriteLine("Please make a menu choice:");
                    Console.WriteLine("1.Enter Triangle DImensions");
                    Console.WriteLine("2.Exit");

                    try
                    {
                        menuOption = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter either 1 or 2");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (menuOption == 0 || menuOption < 0 || menuOption > 2);

                switch (menuOption)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter side A:");
                        try
                        {
                            sideA = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        Console.WriteLine("Please enter side B:");
                        try
                        {
                            sideB = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        Console.WriteLine("Please enter side C:");
                        try
                        {
                            sideC = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        TriangleSolver.Analyze(sideA, sideB, sideC);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (menuOption == 1);
        }
    }
}
