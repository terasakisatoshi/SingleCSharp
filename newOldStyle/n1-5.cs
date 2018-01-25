using System;
using System.Linq;
class Program{
    static void Main(){
        string[] a={"Ichiro","Ziro","SubRho"};
        foreach(var n in a.Select((s,i) => new{s,i})){
            Console.WriteLine(n.s+"-san " +(n.i+1) + "-th");
        }
    }
}