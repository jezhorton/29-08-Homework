using System;
using System.Web.Script.Serialization;

namespace _29_08_19Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 2, valueTwo = 3, valueThree = 4, output;
            Program p = new Program(); //Allowing the calling of methods in the program class(instancing the class)
            Console.WriteLine("Please enter one value");
            valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter one value");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter one value");
            valueThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.sum(valueOne, valueTwo, valueThree, out output));
            /* Cat Code */
            Cat cat1 = new Cat("Tibby", 2); //instance of cat
            Cat.CatAge(cat1);
            Cat.CatAge(cat1); //Adding 10 to the cat age (5 at a time)
            Console.WriteLine("Cat Name: {0}\nCat Age: {1}",cat1.Name,cat1.Age);
            /* JSON Serializer */
            var json = new JavaScriptSerializer().Serialize(cat1);
            Console.WriteLine(json.ToString());
        }

        int sum(int one, int two, int three, out int sum)
        {
            sum = one + two + three;
            return one * two * three;
        }
    }
    class Cat
    {
        private string name;
        private int age;
        public Cat(string name, int age)
        {
            this.name = name; //Using getters and setters
            this.age = age;
        }
        public static object CatAge(Cat cat)
        {
            cat.age = cat.age + 5;
            return cat;
        }
        public string Name
        {
            get => name; set => name = value;
        }
        public int Age
        {
            get => age; set => age = value;
        }
    }     
}
