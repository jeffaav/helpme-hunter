using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HelpmeHunter.Utilitarios
{
    public static class MetodosExtension
    {
        public static int ToInt(this object obj)
        {
            return Convert.ToInt32(obj);
        }

        public static bool ToBool(this object obj)
        {
            return Convert.ToBoolean(obj);
        }

        public static char ToChar(this object obj)
        {
            return Convert.ToChar(obj);
        }

        public static decimal ToDecimal(this object obj)
        {
            return Convert.ToDecimal(obj);
        }

        public static void AddDuplicate<TKey, TValue>(this Dictionary<TKey, List<TValue>> obj, TKey key, TValue value)
        {
            if (obj.ContainsKey(key))
            {
                obj[key].Add(value);
            }
            else
            {
                obj.Add(key, new List<TValue> { value });
            }
        }

        public static SelectList ToSelectList<T>(this IEnumerable<T> lista, string value, string text) where T : class
        {
            return new SelectList(lista, value, text);
        }
    }
}
