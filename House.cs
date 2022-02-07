using System;


namespace FinalAsignement
{
    class Apartment
    {
        public class House
        {
            public int Area { get; set; }
            public Door door;

            public House(int area = 200)
            {
                this.Area = area;
            }

            public void ShowData()
            {
                Console.WriteLine($"The area of my house is {Area} m2");
            }

            public Door GetDoor()
            {
                return door;
            }

            public class Door
            {
                public string Color { get; set; }

                public Door(string color = "white")
                {
                    this.Color = color;
                }

                public void ShowData()
                {
                    Console.WriteLine($"Color of my door is {Color}");
                }
            }
        }

        public class SmallApartment : House
        {
            public SmallApartment(int area = 50) : base(area)
            {
            }
        }

        public class Person
        {
            private string name;
            public House house { get; set; }

            public Person(string name)
            {
                this.name = name;
            }

            public void ShowData()
            {
                Console.WriteLine($"A person whose name is {name}");
                Console.WriteLine("Data of house:");
                house.ShowData();
                Console.WriteLine("Data of door:");
                house.GetDoor().ShowData();
            }

        }

        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Game");
            apartment.door = new House.Door("Green");
            person.house = apartment;
            person.ShowData();
            Console.ReadLine();
        }
    }
}