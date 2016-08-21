using System;

 class MyClass 
{
  public string Name
  {
      get;
      set;
  }
}

class Program{
    static void Main(string[] args){
        MyClass b = new MyClass(){
            Name="Hi,my name is Draemon"
        };
        Console.WriteLine(b.Name);
    }
}