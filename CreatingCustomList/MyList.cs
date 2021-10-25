using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingCustomList
{
    class MyList
    {
        private MyType[] types;
        public MyList(int size)
        {
            types = new MyType[size=10];
        }
        public MyType this[int index]
        {
            get
            {
                try
                {
                    return types[index];
                }
                catch (Exception)
                {

                    return types[0];
                }
            }
            set
            {
                try
                {
                    types[index] = value;
                }
                catch (Exception)
                {

                    Console.WriteLine("Out of range");
                }
            }
        }
        public int Count { get; set; }
    }
}
