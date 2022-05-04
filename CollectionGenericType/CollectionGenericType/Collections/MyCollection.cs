using CollectionGenericType.Collections.Interfaces;
using CollectionGenericType.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType.Collections
{
    class MyCollection<T> where T : Human /*where U : class*/
    {
        T[] arr;

        public MyCollection()
        {
            arr = new T[0];
        }

        public void Add(T obj)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = obj;
        }

        public T Get(int index)
        {
            return arr[index];
        }
    }
}
