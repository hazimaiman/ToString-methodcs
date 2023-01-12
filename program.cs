using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //ToString() = converts obj to its string representation so that it is suitable for display

            Car car = new Car("myvi", "Proton", 2022, " 2032");

            Console.WriteLine(car.ToString());

            Console.ReadKey();
        }
    }

    class Car
    {
        String make;
        public String model;
        int year;
        public String color;

        public Car(String model, String color, int year, String make)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.make = make;
        }
        public override string ToString()
        {
            String message = $"This is a {make} {model}";
            return message;
        }
    }




}







