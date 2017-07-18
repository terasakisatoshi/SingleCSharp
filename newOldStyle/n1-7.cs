using System;
class Program {
    static void Main(string[] args){
        string src="123";
        int result;
        Console.WriteLine(int.TryParse(src, out result) ? result : -1);
    }
}