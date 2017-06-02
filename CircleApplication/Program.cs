using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program prog = new Program();
            prog.menu();
        }
        //Function for calling a Menu
        public void menu()
        {

            double radius;
            int option = 0;
            Console.Clear();
            
            Console.WriteLine("Enter the Radius");
            string r = Console.ReadLine();
            //Exception Handing for radius input
            if (!double.TryParse(r, out radius))
            {
                Console.WriteLine("{0} is not a valid Radius", r);
                Console.ReadLine();
                menu();
            }
            if (radius < 0)
            {
                Console.WriteLine("Radius Can't Be Negative");
                Console.ReadLine();
                menu();

            }
            else
            {

                Console.WriteLine("");

            }
            Circle circle = new Circle(radius);

            do
            {
                Console.WriteLine("\t\t\tMain Menu");
                Console.WriteLine("");
                Console.WriteLine("1. Add to Circle Radius");
                Console.WriteLine("2. Subtract to Circle Radius");
                Console.WriteLine("3. Calculate Circle Circumference");
                Console.WriteLine("4. Calculate Circle Area");
                Console.WriteLine("5. Exit");
                //Exception Handling for Menu input
                bool result = Int32.TryParse(Console.ReadLine(), out option);
                if (result)
                {



                    switch (option)
                    {
                        case 1:
                            circle.addRadius();
                            break;
                        case 2:
                            circle.subtractRadius();
                            break;
                        case 3:
                            Console.WriteLine("Circumference is:" + circle.circumference());
                            break;
                        case 4:
                            Console.WriteLine("Area is:" + circle.area());
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter a Correct Option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Correct option");
                }
                Console.ReadLine();
            } while (option != 5);
        }
    }

        } 


