using System;
class Program{
    static void Main(string[] arags){
        string src="123";
        try{
            Console.WriteLine(int.Parse(src));
        }
        catch(Exception){
            Console.WriteLine(-1);
        }
    }
}