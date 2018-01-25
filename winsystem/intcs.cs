using System;

namespace Main{
    class Program{
        static void Main(string[] args){
            int i=10;
            if (i==10){
                Console.WriteLine("i==10: i is equal 10");
            }else{
                Console.WriteLine("i is not equal 10");
            }

            if(i.Equals(10)){
                Console.WriteLine("i.Equals(10) True");
            }else{
                Console.WriteLine("i.Equals(10) False");
            }
        }
    }
}