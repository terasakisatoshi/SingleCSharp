using System;
class Program{
    static void Main(string[] args){
        string a="We are the World";
        Console.WriteLine(a??"(null)");
    }
}

/*
a が null だった時の対処法について
単純に？？に続けてnull時のデフォルト値を書くことにすれば良いのです．
*/