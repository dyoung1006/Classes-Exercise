using System.Reflection;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Jeep", "Cherokee", 2019);
            myCar.DisplayCarDetails();
            Console.ReadKey();
        }
    }
}

#region - Instructions
//Create a class named Car - make sure it is public
//In the Car class:
//Create a Make property of type string that is public
//Create a Model property of type string that is public
//Create a Year property of type int that is public
//In the Main method:
//Create a new instance of the Car class
//Set values in the properties for the object
//Print the values of each property to the Console
#endregion