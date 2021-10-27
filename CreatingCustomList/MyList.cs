using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingCustomList
{
    public class MyList<T>
    {
        private T[] arr;
        public static int Count { get; set; }
        public MyList()
        {

            arr = new T[10];
        }
        //public MyType this[int index]
        //{
        //    get
        //    {
        //        try
        //        {
        //            return types[index];
        //        }
        //        catch (Exception)
        //        {

        //            return types[0];
        //        }
        //    }
        //    set
        //    {
        //        try
        //        {
        //            types[index] = value;
        //        }
        //        catch (Exception)
        //        {

        //            Console.WriteLine("Out of range");
        //        }
        //    }
        //}
        public void Add(T obj)
        {
            if (Count % 10 == 0) 
            {
                ArrayResize();
            }
            arr[Count] = obj;
            Count++;
        }
        private void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 10);
        }
        
    }
}
