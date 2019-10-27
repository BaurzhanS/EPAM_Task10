using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_Task10.Task4
{
    //public class UniqueOrder: IEnumerable
    //{
    //    dynamic input;

    //    IList list = new List<object>();

    //    public IEnumerator GetEnumerator()
    //    {
    //        return this.input.GetEnumerator();
    //    }

    //    public void UniqueInOrder(object obj)
    //    {
    //        list.Clear();
    //        input = obj;
    //        dynamic lastItem = null;

    //        foreach (var item in input)
    //        {
    //            if (item != lastItem)
    //            {
    //                list.Add(item);
    //                lastItem = item;
    //            }
    //        }

    //        foreach (var item in list)
    //        {
    //            Console.Write(item);
    //        }
    //        Console.WriteLine();
    //    }
    //}

    public class UniqueOrder<T,K> : IEnumerable<T>
    {
        List<K> list = new List<K>();
        dynamic input;

        public List<K> UniqueInOrder(T obj)
        {
            input = obj;
            dynamic lastItem = null;
            
            foreach (var item in input)
            {
                if (item != lastItem)
                {
                    list.Add(item);
                    lastItem = item;
                }
            }

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            return list;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.input.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
