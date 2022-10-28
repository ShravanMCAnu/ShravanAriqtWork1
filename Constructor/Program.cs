using System;

namespace MyApplication
{
   
    class Car
    {
        public string model;  
        public string color;
        public int year;
        public Car(string modelName, string modelColor, int modelYear)
        {
            model =modelName; 
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang","Red",1969);  
            Console.WriteLine(Ford.model+" "+Ford.year+" "+Ford.color);
        }
    }
}