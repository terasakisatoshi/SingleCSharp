//C#4.0からは引数の省略ができるので，単純に省略で対処できる
//メソッドの違いはオーバーロードしなくてもよい．
using System;
static class A{
    static internal void SayHello(string name =null,int age=-1){
        if(age>=0) Console.Write("{0}才の",age);
        if(name!=null) Console.Write("{0}さん ",name);
        Console.WriteLine("Hello!");
    }
}

class Program{
    static void Main(string[] args){
        A.SayHello("TAROU",17);
        A.SayHello("HANAKO");
        A.SayHello();
    }
}