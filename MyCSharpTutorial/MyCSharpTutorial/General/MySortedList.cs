using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpTutorial.General
{
    class MySortedList
    {
        int[] items = new int[0];
        public int[] Items
        {
            get { return items; }
            set { items = value; }
        }

        public void Add(int value)
        {
            int index = Array.BinarySearch(items, value);
            if (index < 0)
                index = ~index;

            //Increase Items Array Size by 1
            int lastIndex = items.Length;
            int capacity = items.Length + 1;
            int[] dupArray = new int[capacity];
            Array.Copy(items, dupArray, items.Length);
            items = dupArray;

            //Adjusting elements to insert element in its right index
            if (index < lastIndex)
            {
                Array.Copy(items, index, items, index + 1, lastIndex - index);
            }
            items[index] = value;
        }
    }
}
