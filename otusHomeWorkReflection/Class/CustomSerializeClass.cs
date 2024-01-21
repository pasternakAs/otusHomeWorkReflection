using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkReflection.Class
{
    public static class CustomSerializeClass
    {
        /// <summary>
        /// Серелизация
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            var sb = new StringBuilder();
            Type t = obj.GetType();

            foreach (var field in t.GetFields())
            {
                sb.Append($"[{field.Name}:{field.GetValue(obj)}]\n");
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        /// <summary>
        /// Десерилизация
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializedString"></param>
        /// <returns></returns>
        public static object Deserialize<T>(string serializedString) where T : class, new()
        {
            var obj = new T();
            var type = obj.GetType();
            var arr = serializedString.Split("\n");

            foreach (var item in arr)
            {
                var serializedField = item.Trim('[').Trim(']').Split(":");
                var field = type.GetField(serializedField[0]);

                if (field == null) continue;
                field.SetValue(obj, ConvertClass.ConvertValue(field.FieldType, serializedField[1]));
            }

            return obj;
        }
    }
}