using System;
class Program{
    static void Main(string[] args){
        string[] a={"Ichiro","Ziro","SubRho"};
        int count=1;
        foreach (var n in a) 
        {
            Console.WriteLine(n+"-san is " +count+"-th");
            count++;
        }
    }
}