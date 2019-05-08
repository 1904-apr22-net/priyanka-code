using System;
using System.Collections.Generic;

namespace CollectionTesting.Library
{
    public class GenericCollection<T> : IEnumerable<T>
    {
        protected List<T> _list { get; } = new List<T>();
       public GenericCollection(IEnumerable<T> coll)
        {
            List.Add
        }
        // Console.WriteLine("Hello World!");
        public IEnumerable<T> GetEnumerator() => ((IEnumerable<T>)List).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable))
        }
    }
}


