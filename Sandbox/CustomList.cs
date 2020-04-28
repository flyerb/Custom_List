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


            if(items.Length == 1)
            {
                items[0] = item;  
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
                value = Math.Pow(i, 2); //the value in the indexer
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
