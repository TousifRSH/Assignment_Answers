﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    public class Circle
    {
        public double radius;


        public Circle(double r)
        {
            radius = r;

        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Cylinder
    {
        public Circle dt;
        public double height;
        public string color;

        public Cylinder(double r, double h, string c)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinder(double r, double h)
        {
            dt = new Circle(r);
            height = h;
        }
        public Cylinder(double r)
        {
            dt = new Circle(r);

        }



        public double getVolume()
        {
            return dt.getArea() * height;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //  Circle circle = new Circle(12.34);

            Cylinder cylinders = new Cylinder(12.34, 10.0, "blue");
            //double area=circle.getArea();
            // Console.WriteLine(area);
            //Console.WriteLine(circle1.color);


            Cylinder[] circles = {
                                new Cylinder(80),

                            new Cylinder(12.3,30.7),
                                    new Cylinder(12.34, 10.0, "blue")
                                };

            Console.WriteLine(circles[1].getVolume());


            // Console.WriteLine(circles[0].getVolume());
            //Console.WriteLine(circle[0].getArea());

            //Console.WriteLine(cylinder.getVolume());


        }
    }
}
