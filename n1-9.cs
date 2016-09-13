using System;

enum 有効無効
{
    有効=1,
    無効=0
};

public class Program{
    public static void Main(string[] args){
        有効無効 a;
        Enum.TryParse<有効無効>("はてな",out a);
        Console.WriteLine(a);
    }
}

/*
列挙型のデフォルト値は数値の0に対応するので，数値のゼロに対応する列挙値を無効の時に使用する
値と一致させると，TryParseが有効に機能します．
*/