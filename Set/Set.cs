using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private HashSet<T> hashSet;

        public Set()
        {
            hashSet = new HashSet<T> ();
        }
        public int Size => hashSet.Count;

        public List<T> Elements
        {
            get
            {
                List<T> elements = new List<T>();
                foreach (var item in hashSet)
                {
                    elements.Add (item);
                }
                return elements;
            }
        }

        public void Add(ISet<T> s)
        {
            foreach (var item in s)
            {
                hashSet.Add(item);
            }
        }

        public void Add(T value)
        {
            hashSet.Add(value);
        }

        public bool Contains(T value)
        {
            if (hashSet.Contains(value) == true)
            {
                return true;
            }
            return false;
        }

        public void Remove(ISet<T> s)
        {
            foreach (var item in s)
            {
                hashSet.Remove(item);
            };
        }

        public void Remove(T value)
        {
            hashSet.Remove(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return hashSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Set<T> Union(ISet<T> set1, ISet<T> set2)
        {
            Set<T> Union = new Set<T>();
            foreach (var item in set1)
            {
                foreach (var item2 in set2)
                {
                    if (item.Equals(item2) == false)
                    {
                        Union.Add(item);
                        Union.Add(item2);
                    }
                }
            }
            return Union;
        }

        public static Set<T> Intersection(ISet<T> set1, ISet<T> set2)
        {
            Set<T> Intersection = new Set<T>();
            foreach (var item in set1)
            {
                foreach (var item2 in set2)
                {
                    if (item.Equals(item2))
                    {
                        Intersection.Add(item);
                    }
                }
            }
            return Intersection;
        }
    }
}
