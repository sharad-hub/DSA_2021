using Newtonsoft.Json;

namespace DSA2021
{
    public static class ExtensionMethods
    {
        public static string ToJsonStirng<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
