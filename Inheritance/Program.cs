using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName); 
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySal;
}

public  class PartTimeEmployee : Employee
{
    public float HourlyRate;
}
public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "shravan";
        FTE.LastName = "Kumar";
        FTE.Email = "bsk@gmail.com";
        FTE.YearlySal = 1500.00F;
        FTE.PrintFullName();

        PartTimeEmployee PTE=new PartTimeEmployee();
        PTE.FirstName = "Ashok";
        PTE.LastName = "Kumar";
        PTE.Email = "ak@gmail.com";
        PTE.HourlyRate = 85.25F;
        PTE.PrintFullName();
    }
}