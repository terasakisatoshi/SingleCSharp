using System;

enum 有効無効
{
    有効=0,
    無効=1
};

class Program{
    static void Main(string[] args){
        有効無効 a;
        if(Enum.TryParse<有効無効>("はてな",out a)){
            Console.WriteLine(a);
        }
        else{
            Console.WriteLine(有効無効.無効);
        }
    }
}