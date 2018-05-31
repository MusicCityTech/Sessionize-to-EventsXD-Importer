using Newtonsoft.Json;

namespace SessionizeWrapper
{
    public static class Extensions
    {
      public static string ToJson<T>(this T entity, bool format = true)
        {
            return JsonConvert.SerializeObject(entity,
                format
                ? Formatting.Indented
                : Formatting.None);
        }

        public static T FromJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ToFormattedJson(this string json)
        {
            dynamic deserialized = JsonConvert.DeserializeObject(json);

            return JsonConvert.SerializeObject(deserialized, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
