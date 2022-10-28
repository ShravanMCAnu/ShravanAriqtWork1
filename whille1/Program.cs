string[] cars= {"Volvo","BMW","Ford","Mazdaa","TATA"};
int[] myNum = {30,10,50,20,40};
foreach (int i in myNum)
{
    Console.WriteLine(i);
}
Array.Sort(myNum);
foreach (int i in myNum)
{
    Console.WriteLine(i);
}
Console.WriteLine(myNum.Max());
Console.WriteLine(myNum.Min());
Console.WriteLine(myNum.Sum());
foreach (string j in cars)
{
    Console.WriteLine(j);
}
Array.Sort(cars);
foreach (string j in cars)
{
    Console.WriteLine(j);
}
Console.WriteLine(cars[0]);
cars[0] = "opel";
Console.WriteLine(cars[0]);
Console.WriteLine(cars.Length);
Console.WriteLine(cars[4]);