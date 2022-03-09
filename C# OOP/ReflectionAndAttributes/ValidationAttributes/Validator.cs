using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attributes = property
                    .GetCustomAttributes()
                    .Where(x => x.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var item in attributes)
                {
                    bool isValid = item.IsValid(property.GetValue(obj));

                    if (!isValid)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}