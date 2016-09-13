/*
文字列を整数に変換する．解析できない場合は0として扱うようにする．
*/
using System;
class Program{
    static void Main(string[] args){
        string src="123";
        try{
            Console.WriteLine(int.Parse(src));
        }
        catch (Exception){
            Console.WriteLine(0);
        }
    }
}