using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    { 
        //As a developer, I want a read-only Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance.

        // member variables (HAS A)
        private T[] items;

        private int count
        {
            get
            {
                return count;
            }
        }

        public int capacity;

        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            if(items.Length == 1)
            {
                items[0] = item;   //add to array "list
            }
            else if(items.Length == 2)
            {
                items[1] = item;
            }
            else if(items.Length == 3)
            {
                items[2] = item;
            }
            else if(items.Length == 4)
            {
                items[3] = item;
            }
            if (items.Length == 4)
            {
                int i = 
                    = Math.Pow(i, 2);
                items = new T[i];
            }

            // if max capacity is met then do this...
            //create a methods that doubles the array size and also copies values over from the first array. 
            //int[] items = new int[4];
            //items = new int [8];

        }

        public bool Remove(T item)
        {
            return false;
        }
    }
}
