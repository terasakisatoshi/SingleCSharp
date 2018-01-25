using System;
class Program{
    static void Main(){
        string[] a ={"Ichiro","Ziro","SubRho"};
        for (int i=0;i<a.Length;i++){
            Console.WriteLine(a[i] + "-san is " + (i+1) + "-th");
        }
    }
}