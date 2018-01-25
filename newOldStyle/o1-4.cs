using System;
static class A{
    static internal void SayHello(string name ,int age){
        if(age>=0) Console.Write("{0}才の",age);
        if(name !=null) Console.Write("{0}さん",name);
        Console.WriteLine("Hello!");
    }
    static internal void SayHello(string name){
        SayHello(name,-1);
    }
    static internal void SayHello(){
        SayHello(null,-1);
    }
}

class Program{
    static void Main(string[] args){
        A.SayHello("TAROU",17);
        A.SayHello("HANAKO");
        A.SayHello();
    }
}
