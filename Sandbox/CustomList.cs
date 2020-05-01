using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>: IEnumerable
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

        //IEnumerator 

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];

            }
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

                for (int i = 0; count > i; i++)
                {
                    tempArrary[i] = items[i];
                }

                items = tempArrary;
            }

        }



        public bool Remove(T item)
        {
            bool hasFound = false;
            for (int i = 0; count > i; i++)
            {
                
                if (items[i].Equals(item))
                {
                    hasFound = true;
                    count--;
                }

                if (hasFound == true)
                {
                    items[i] = items[i + 1];
                }
            }
            return hasFound;
        }

        public override string ToString()
        {
            string newString = "";
     
            for (int i = 0; i < count; i++)
            {
                newString += items[i].ToString();

            }
            return newString;
        }

        public static CustomList<T>  operator+ (CustomList<T> listOne, CustomList<T> listTwo)
        {
    
            CustomList<T> finalList = new CustomList<T>();
          

            for (int i = 0; i < listOne.count; i++)
            {
                finalList.Add(listOne[i]);

            }

            for (int i = 0; i < listTwo.count; i++)
            {
                finalList.Add(listTwo[i]);

            }

            return finalList;
        }


        public static CustomList<T> operator- (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalList = new CustomList<T>();

            for (int i = 0; i < listOne.count; i++)
            {
                finalList.Add(listOne[i]);
                if (listOne[i].Equals(listOne[i +1]))
                {
                    finalList.Remove(listOne[i]);
                }

            }

            for (int i = 0; i < listTwo.count; i++)
            {
                finalList.Add(listTwo[i]);
                if (listTwo[i].Equals(listTwo[i + 1]))
                {
                    finalList.Remove(listTwo[i]);
                }

            }
            return finalList;

        }

        public CustomList<T> Zipper(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalList = new CustomList<T>();


            for (int i = 0; i < count; i++)
            {
                finalList.Add(listOne[i]);
                finalList.Add(listTwo[i]);

            }

            return finalList;
        }
    }
}
  

//customer iterator

//class inherits the IEnumerable interface --- this will allow you to use a foreach loop on the custom lists class
//using systems:collections at top  of page  if IEnumberable is white and not light green
//implement the interface by right clicking and finding it 
//put a for loop with count inside GetEnumerator()
//yield return daysArray[index] /// items[count]