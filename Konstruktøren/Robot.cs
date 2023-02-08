using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktøren
{
    internal class Robot
    {
        private string coloured = "White ";
        private string chip;
        private bool wifi;
        private int batterycapacity;
        private double soapcapacity;
        private bool small;
        private int wheels;
        public string Coloured
        {
            get { return coloured; }
            set { coloured = value; }
        }
        public string Chip
        {
            get { return chip; }
            set { chip = value; }
        }
        public bool Wifi
        {
            get { return wifi; }
            set { wifi = value; }
        }
        public int Batterycapacity
        {
            get { return batterycapacity; }
            set { batterycapacity = value; }
        }
        public double Soapcapacity
        {
            get { return soapcapacity; }
            set { soapcapacity = value; }
        }
        public bool Small
        {
            get { return small; }
            set { small = value; }
        }
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }
        public Robot(bool small, int wheels)//Default Robot propities
        { 
            this.Small = small;
            this.Wheels = wheels;
        }
        public Robot(bool wifi, bool small, int wheels) : this(small, wheels)//robot setting for default
        {
            this.Wifi = wifi;
        }
        public Robot(string chip, bool wifi, bool small, int wheels) : this(wifi, small, wheels)//robot setting for default
        {
            this.Chip = chip;
        }
   
        public Robot(string coloured, string chip, bool wifi, bool small, int wheels) : this(chip, wifi, small, wheels)//robot setting for default
        {
            this.Coloured = coloured;
        }
        public Robot(int batterycapacity, string chip, bool wifi, bool small, int wheels) : this(chip, wifi, small, wheels)//robot setting for default
        {
            this.Batterycapacity = batterycapacity;
        }
        public Robot(string coloured, string chip, bool wifi, double soapcapacity, bool small, int wheels) : this(coloured, chip, wifi, small, wheels)//robot settings for Cleaner
        {
            this.Soapcapacity = soapcapacity;
        }
        public void Info()//this will show the info on robots
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Robot Info: ");
            if (this.Coloured == "White")
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Coloered: "+ this.Coloured);
            Console.WriteLine("Chip: " + this.Chip);
            Console.WriteLine("Wifi: " + this.Wifi);
            Console.WriteLine("Small: " + this.Small);
                
            if (!this.small)//if there it is small. it will either show to wheels, or it will be removed.
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Wheels: " + this.Wheels);
                Console.ResetColor();

            }
            if (this.Batterycapacity > 0)//if there is zero on the battery, it will be removed.
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Battery: " + this.Batterycapacity);
            }
            if (this.Soapcapacity > 0)//if there is zero on the soap, it will be removed.
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Soap: " + this.Soapcapacity);
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
