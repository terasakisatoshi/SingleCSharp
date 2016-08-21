using System;
class MyClass 
{
  public string Name{get;set;}
}

class Program{
    static void Main(string[] args)
    {
        MyClass b = new MyClass(){ Name = "I am Draemon."};
        Console.WriteLine(b.Name);
    }
}