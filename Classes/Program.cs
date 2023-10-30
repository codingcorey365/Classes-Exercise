using System.Reflection;

namespace Classes
{
    public class Program
    {
        //Create a class named Car - make sure it is public
        //In the Car class:
        //Create a Make property of type string that is public
        //Create a Model property of type string that is public
        //Create a Year property of type int that is public
        //In the Main method:
        //Create a new instance of the Car class
        //Set values in the properties for the object
        //Print the values of each property to the Console


        static void Main(string[] args)
        {
            var miahsCar = new Car();
            miahsCar.Make = "Toyota";
            miahsCar.Model = "Rav4";
            miahsCar.Year = 2012;

            Console.WriteLine( $"Miah has an awesome car. Her car is a {miahsCar.Year} {miahsCar.Make} {miahsCar.Model}" );


        }
    }
}
