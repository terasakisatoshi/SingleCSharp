using System;
class Program{
    private static bool myMethod(int x){
        return x>100;
    }

    static void Main(string[] args){
        Console.WriteLine(myMethod(100));
        Console.WriteLine(myMethod(101));
    }
}