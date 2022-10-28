using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor called");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass():base("Derived class controlling Parent class")
    {
        Console.WriteLine("ChilldClass Constructor called");
    }
}

public class program 
{ public static void Main()
    {
        ChildClass CC=new ChildClass();
        
    }
}