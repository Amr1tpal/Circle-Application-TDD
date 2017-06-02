using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApplication
{
    //Declared Circle class
    public class Circle
    {
        private double r;
        public double radius
        {
            get
            {
                return this.r;
            }
            set
            {
                this.r = value;
            }
        }
        //Constructor for Circle class
        public Circle()
        {
            radius = 0.0;
        }
        //Contructor with arguments for Circle class
        public Circle(double rad)
        {
            radius = rad;
        }
        //Method for adding a value to the Radius
        public double addRadius()
        {
            double val;
            Console.WriteLine("Enter a Valid Number");
            string r = Console.ReadLine();
            if (!double.TryParse(r, out val))
            {
                Console.WriteLine("{0} is not a valid Radius", r);
                Console.ReadLine();
            
            }
          
            double incRadius = radius + val;
            if (incRadius < 0)
            {
                Console.WriteLine("Radius Cant be Negative");
                return radius;
            }
            else
            {
                Console.WriteLine("Increased Radius is:" + incRadius);
                radius = incRadius;
            }
         return incRadius;
        }
        public void addRadiuss(double r)
        {
            radius = radius + r;

        }
        //Method for subtracting a value from the Radius
        public double subtractRadius()
        {
            double val;
            Console.WriteLine("Enter a Valid Number");
            string r = Console.ReadLine();
            if (!double.TryParse(r, out val))
            {
                Console.WriteLine("{0} is not a valid Radius", r);
                Console.ReadLine();

            }
            double decRadius = radius - val;
          
            if (decRadius < 0)
            {
                Console.WriteLine("Radius Cant be Negative");
                return radius;
            }
            else
            {
                  Console.WriteLine("Decreased Radius is:" + decRadius);
                radius = decRadius;
            }
            return decRadius;
        }
        public void subRadiuss(double r)
        {
            radius = radius - r;

        }
        //Method for calculating a Circumference
        public double circumference()

        {
            return Math.Round((2 * Math.PI * radius),2);
        }
        //Method for calculating a Area
        public double area()
        {
            return Math.Round((Math.PI * (radius*radius)),2);
        }
       
        
    }

}
