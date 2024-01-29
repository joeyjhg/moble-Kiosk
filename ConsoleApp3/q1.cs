using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp3
{    
    internal class q1
    {                
        delegate void TypeF(int a, int b);

        static void Plus(int x,int y) { Console.WriteLine(x + y); }
        static void Minus(int x, int y) { Console.WriteLine(x - y); }
        static void Multiple(int x, int y) { Console.WriteLine(x * y); }

        static void Main(string[] args)
        {
            TypeF delgateValue1 = Plus;
            TypeF delgateValue2 = Minus;
            TypeF delgateValue3 = Multiple;

            delgateValue1 += delgateValue2;
            delgateValue1 += delgateValue3;
            delgateValue1(20, 10);
        }
    }

}
