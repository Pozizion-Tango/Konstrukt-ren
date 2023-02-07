using System;
using System.Drawing;

namespace Konstruktøren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool newrobot = true;// a true statment, used in the code later to help if the user wants to close the program
            Random rnd = new Random();//used for 1/2 chances for the robot to have either a true or false statment
            while (newrobot)
            {
                newrobot = true;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==============================================");
                Console.WriteLine("===        ======          ====          =====");
                Console.WriteLine("=   ======   ===   ======   ===  =======  ====");
                Console.WriteLine("=   ======   ===  ========  ===  =======  ====");
                Console.WriteLine("=   ======   ===  ========  ===         ======");
                Console.WriteLine("=          =====  ========  ===         ======");
                Console.WriteLine("=   =====   ====  ========  ===  =======  ====");
                Console.WriteLine("=   ======   ===   ======   ===  =======  ====");
                Console.WriteLine("=   =======   ===          ====          =====");
                Console.WriteLine("==============================================");
                Console.WriteLine("==============================================");
                Console.WriteLine("======         ============           ========");
                Console.WriteLine("=====   ==================   =======   =======");
                Console.WriteLine("====   ===================  =========  =======");
                Console.WriteLine("====  ====================  =========  =======");
                Console.WriteLine("====  ====================  =========  =======");
                Console.WriteLine("====   ===================  =========  =======");
                Console.WriteLine("=====   ==================   =======   =======");
                Console.WriteLine("======         ============           ========");
                Console.WriteLine("==============================================\r\n\r\n");
                Console.ResetColor();
                Console.WriteLine("1: Generate Robot Type (default)\r\n2: Generate Robot Type (Cleaner)\r\n0: Exit");
                string choice = Console.ReadLine();//above to user gets told what they can select. And Choice is their selected number.
                bool colour = false;//Default setting
                string chip = "RX54667";//Default setting
                bool wifi = false;//Default setting
                int batterycapacity = 255;//Default setting
                if (rnd.Next(0, 2) == 0)//Chancing if the robot will have Wifi
                    wifi = true;
                
                if (rnd.Next(0, 2) == 0)
                {
                    colour = true;
                    batterycapacity = 0;
                }
                double soapcapacity = 2.3;//Default setting
                bool small = false;//Default setting
                int wheels = 0;//Default setting
                if (rnd.Next(0, 2) == 0)//Chanching if the Robot will be Small
                    small = true;
                if (!small)//Chanching if it got wheels if the robot is not small, and how many wheels.
                    wheels = rnd.Next(0, 5);
                if (rnd.Next(0, 2) == 0)//Using chance to choose it's chip
                    chip = "QT8339";
                if (choice == "1")//If choice is 1, it will have the "Default setting"
                {
                    Robot robot1 = new Robot(colour, batterycapacity, chip, wifi, small, wheels);
                    robot1.Info();
                }
                else if (choice == "2")//If choice is 2, it will have the "Cleaner setting"
                {
                    Robot robot1 = new Robot(colour, chip, wifi, soapcapacity, small, wheels);
                    robot1.Info();
                }
                else if (choice == "0")//if choice is 0 it will take "newrobot" and turn it false to stop the program from repeating
                {
                    newrobot = false;
                }
                else//if the user miss spells it will warn the user and restart
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid, press any key to continue");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}
