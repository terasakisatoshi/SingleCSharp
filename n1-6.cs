using System;
using System.Linq;
class Program{
    static void Main(){
        string[] a={null,"TAROU",null,"HANAKO"};
        foreach (var n in a.Where(c=> c!=null)) 
        {
            Console.WriteLine(n+"san");            
        }
    }
}