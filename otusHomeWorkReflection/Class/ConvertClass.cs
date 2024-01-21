using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkReflection.Class
{
    public static class ConvertClass
    {
        /// <summary>
        /// Конвертация
        /// </summary>
        /// <param name="type">тип для конвертации</param>
        /// <param name="value">значение</param>
        /// <returns></returns>
        public static object ConvertValue(Type type, string value)
        {
            switch (type.Name)
            {
                case "Int32":
                    return int.Parse(value);
                default:
                    return 0;

            }
        }
    }
}
