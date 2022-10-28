using System;
public class student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark ;
    }
    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Student Name cannot be Null or Empty");
        }
        this._name = Name;
    }
    public string GetName() 
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
    }

    public void  SetId(int Id)
    {
        if (Id <= 0)
        {
             throw new Exception("Student Id cannot be negative");
        }
        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }

}

public class Programm1
{
    public static void Main()
    {
        student C1 = new student();
        C1.SetId(101);
        C1.SetName("Shravan");
        Console.WriteLine("Student Id={0}\nStudent Name={1}\nStudent PassMark={2}",C1.GetId(),C1.GetName(),C1.GetPassMark()); 
    }
}