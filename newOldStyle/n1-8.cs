using System;
class Program{
    static void Main(string[] args){
        string src="123";
        int result;
        int.TryParse(src,out result);
        Console.WriteLine(result);
    }
}

/*
TryParseメソッドは変換できない場合0を出力することが保証されている．
*/