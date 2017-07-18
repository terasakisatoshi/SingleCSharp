using System;

 class Program 
{
  static void Main(){
    string[] a={null,"TAROU",null,"HANAKO"};
    foreach (var n in a) 
    {
        if(n!=null){
            Console.WriteLine(n+"-san");
        }
    }
  }
}