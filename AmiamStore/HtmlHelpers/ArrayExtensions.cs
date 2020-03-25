using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.HtmlHelpers
{
    public static class ArrayExtensions
    {
        public static int IndexOf<TSource>(this TSource[] array, Func<TSource, bool> predicate)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (predicate.Invoke(array[i]))
                    return i;
            }
            return -1;
        }

    }
}