using System;
using System.Collections.Generic;

namespace CreatingCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("Gnl1");
            list.Add("Gnl2");
            list.Add("Gnl3");
            list.Add("Gnl4");
        }
    }
}
