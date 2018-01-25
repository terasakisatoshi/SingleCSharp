using System;
class A{
    public string Id{ get {return "004989"; } }
}

class Program{
    static void Main(string[] args){
        A a = new A();
        Console.WriteLine(a.Id);
    }
}