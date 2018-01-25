using System;
class Program
{
    static void Main(string[] args){
        int[] iArray = new int[3];
        for (int i=0; i<iArray.Length; i++) 
        {
            iArray[i]=i;
        }
        for (int i=0; i<iArray.Length; i++) 
        {
            Console.WriteLine("iArray[{0}]={1}",i,iArray[i]);
        }
    }
}