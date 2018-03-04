using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSharp.Extensions
{
    static class EnumerableExtensions
    {
        public sealed class ZipEntry<T1, T2>
        {
            public ZipEntry(int index, T1 value1, T2 value2)
            {
                Index = index;
                Value1 = value1;
                Value2 = value2;
            }

            public int Index { get; private set; }
            public T1 Value1 { get; private set; }
            public T2 Value2 { get; private set; }
        }
        public static IEnumerable<ZipEntry<T1, T2>> Zip<T1, T2>(
            this IEnumerable<T1> collection1, IEnumerable<T2> collection2)
        {
            if (collection1 == null)
                throw new ArgumentNullException("collection1");
            if (collection2 == null)
                throw new ArgumentNullException("collection2");

            int index = 0;
            using (IEnumerator<T1> enumerator1 = collection1.GetEnumerator())
            using (IEnumerator<T2> enumerator2 = collection2.GetEnumerator())
            {
                while (enumerator1.MoveNext() && enumerator2.MoveNext())
                {
                    yield return new ZipEntry<T1, T2>(
                        index, enumerator1.Current, enumerator2.Current);
                    index++;
                }
            }
        }

        public sealed class ZipEntry<T1, T2, T3>
        {
            public ZipEntry(int index, T1 value1, T2 value2, T3 value3)
            {
                Index = index;
                Value1 = value1;
                Value2 = value2;
                Value3 = value3;
            }

            public int Index { get; private set; }
            public T1 Value1 { get; private set; }
            public T2 Value2 { get; private set; }
            public T3 Value3 { get; private set; }
        }
        public static IEnumerable<ZipEntry<T1, T2, T3>> Zip<T1, T2, T3>(
            this IEnumerable<T1> collection1,
            IEnumerable<T2> collection2,
            IEnumerable<T3> collection3)
        {
            if (collection1 == null)
                throw new ArgumentNullException("collection1");
            if (collection2 == null)
                throw new ArgumentNullException("collection2");
            if (collection3 == null)
                throw new ArgumentNullException("collection3");

            int index = 0;
            using (IEnumerator<T1> enumerator1 = collection1.GetEnumerator())
            using (IEnumerator<T2> enumerator2 = collection2.GetEnumerator())
            using (IEnumerator<T3> enumerator3 = collection3.GetEnumerator())
            {
                while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext())
                {
                    yield return new ZipEntry<T1, T2, T3>(
                        index, enumerator1.Current, enumerator2.Current, enumerator3.Current);
                    index++;
                }
            }
        }


        public static bool IsAssignableFrom(this IEnumerable<Type> types, IEnumerable<Type> otherTypes)
        {
            if (types.Count() != otherTypes.Count()) return false;

            foreach (var it in types.Zip(otherTypes))
            {
                if (!it.Value1.IsAssignableFrom(it.Value2)) return false;
            }
            return true;
        }
    }

}
