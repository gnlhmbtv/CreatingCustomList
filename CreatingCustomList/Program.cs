using System;
using System.Collections.Generic;

namespace CreatingCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> number = new List<int>();
            number[0] = 45;
            Console.WriteLine(number[0]);*/
            MyType type1 = new MyType();
            MyList list = new MyList(10);
            list[9] = type1;
            Console.WriteLine(list[9]);
        }
    }
}
