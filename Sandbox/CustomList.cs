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
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }


        private T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }


    // constructor (SPAWNER)
 
    public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];

        }

        
        // member methods (CAN DO)
        public void Add(T item)
        {

            items[count] = item;
            count++;

            if (capacity == count)
            {
                capacity = capacity * 2;

                for(int i = 0; count > i; count++)
                {
                    item = 
                }
            }

            // if max capacity is met then do this...
            //create a methods that doubles the array size and also copies values over from the first array. 
            //int[] items = new int[4];
            //items = new int [8]; //items = new T[capacity];

        }

        public bool Remove(T item)
        {
            return false;
        }
    }
}
