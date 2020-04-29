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


        public T this[int i]
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
                T[] tempArrary = new T[capacity];

                for(int i = 0; count > i; i++)
                {
                    tempArrary[i] = items[i];
                }

                items = tempArrary;
            }

        }
         
        public bool Remove(T item)
        {
            for (int i = 0; count > i; i++)
            {
                if (items[i].Equals(item))
                    for (int a = 0; count > a; a++)
                    {
                        items[a] = items[a++];
                        count--;
                        return true;
                    }
                
            }
            return false;
        }


        //for loop to look for the value and once it finds the value shift the other values over and decrement the count. 

        // 45 30 20 30 & & & &
        // r/30
        // 45 20 30 & & & & &
        // count 
    }
}
