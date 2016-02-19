using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CustomList<T>
    {
        private T[] StringArray;

        public CustomList()
        {
            StringArray = new T[0];
        }

        public T this[int key]
        {
            get
            {
                return StringArray[key];
            }
            set
            {
                StringArray[key] = value;
            }
        }
        public void Add(T thing)
        {
            T[] tempArray = new T[StringArray.Length + 1];
            for (int i = 0; i < StringArray.Length; i++)
            {
                tempArray[i] = StringArray[i];
            }
            tempArray[StringArray.Length] = thing;
            StringArray = tempArray;
        }
        public bool Contains(T thing)
        {
            bool isFound = false;
            for (int i = 0; i < StringArray.Length; i++)
            {
                if (StringArray.Contains(thing))
                {
                    isFound = true;
                }
            }
            return isFound;
        }

    }
}
