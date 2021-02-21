using System;
using System.Collections.Generic;

namespace Model
{
	public static class ObjectHelper
	{
		public static void Swap<T>(ref T t1, ref T t2)
		{
			T t3 = t1;
			t1 = t2;
			t2 = t3;
		}

        public static T[] Reverse<T>(this T[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        public static T[] Combine<T>(this T[] a, T[] b)
        {
            List<T> arr = new List<T>(a);
            arr.AddRange(b);
            return arr.ToArray();
        }

        public static T[] Clone<T>(this T[] arr)
        {
            return Clone(new List<T>(arr)).ToArray();
        }

        public static List<T> Clone<T>(this List<T> list)
        {
            List<T> copy = new List<T>(list);
            return copy;
        }

        public static Dictionary<K, V> Clone<K, V>(this Dictionary<K, V> dict)
        {
            Dictionary<K, V> copy = new Dictionary<K, V>();
            foreach (var pair in dict)
            {
                copy.Add(pair.Key, pair.Value);
            }
            return copy;
        }
    }
}