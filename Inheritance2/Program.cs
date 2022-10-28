class Vehicle
{
    public string brand = "ford";
    public void honk()
    {
        Console.WriteLine("Tuut,tuut!");
    }
}

class Car : Vehicle
{
    public string modelNmae = "Mustang";
}
class Program
{
    static void Main(String[] args)
    {
        Car mycar=new Car();
        mycar.honk();
        Console.WriteLine(mycar.brand+" "+mycar.modelNmae);
    }
}