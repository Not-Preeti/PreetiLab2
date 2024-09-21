/*
using System;
namespace PreetiLab2
{
    class Person
    {
        private string location;
        private string name = "Preeti Shrestha";
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                if (value == "Preeti")
                    name = value;
            }
        }
    }
    class Properties
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // set accessor will invoke
            p.Name = "Nana";
            // set accessor will invoke
            p.Location = "Dhading";
            // get accessor will invoke
            Console.WriteLine("Name: " + p.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + p.Location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
*/