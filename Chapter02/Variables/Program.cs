using System.Xml;
namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; //storing as double in an object
            object name = "Amir";
            Console.WriteLine($"{name} is {height} metres tall.");

            //int length = name.Length; //gives compile error!
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");

            //storing a string in a dynamic object
            //string has a Length property
            dynamic something = "Ahmed";

            //int does not have a Length property
            something = 12;

            // an array of any type has a Length property
            something = new[] { 3, 5, 7 };

            // this compiles but would throw an exception at run-tume
            // if you later store data type that does not have a 
            // property named Length
            Console.WriteLine($"Length is {something.Length}");

            var population = 66_000_000; //66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; //in pounds sterling
            var fruit = "Apples"; //string use double-quotes
            var letter = 'Z'; //chars use single-quotes
            var happy = true; //Booleans have value of true or false

            //good use of var because it avoids the repeated type
            //as shown in the more verbose second statement
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();

            //bad use of the var because we cannot thel the type, so we
            //should use a specific tpye declaration as shown in
            //the second statement
            var file1 = File.CreateText("something1.text");
            StreamWriter file2 = File.CreateText("something2.text");

            XmlDocument xml3 = new();


            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

            int number = 13;
            Console.WriteLine($"number has been set to: {number}");
            number = default;
            Console.WriteLine($"number has been reset to its default: {number}");

            string[] names;
            names = new string[4];

            //storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for(int i = 0; i< names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };


        }
    }
}



