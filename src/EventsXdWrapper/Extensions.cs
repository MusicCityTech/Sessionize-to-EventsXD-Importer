using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace EventsXdWrapper
{
    public static class Extensions
    {
        public static RestRequest CreateEventsXdRequest(this RestClient client, string resource, Method method)
        {
            var request = new RestRequest(resource, method);

            request.AddHeader("Accept", "application/json, text/plain, */*");
            request.SetCookieHeader();

            return request;
        }

        public static void SetCookieHeader(this RestRequest request)
        {
            request.AddParameter("ARRAffinity", "someValue", ParameterType.Cookie);
            request.AddParameter("__RequestVerificationToken", "someValue", ParameterType.Cookie);
            request.AddParameter("__stripe_mid", "someGuid", ParameterType.Cookie);
            request.AddParameter("__stripe_sid", "someGuid", ParameterType.Cookie);
            request.AddParameter("currentConference", "someConference", ParameterType.Cookie);
            request.AddParameter(".EventBoardLocal_ASPXAUTH", "someValue", ParameterType.Cookie);
        }

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

        //Expantionary, Get it? Expando Dictionary lol
        public static IList<IDictionary<string, object>> ToExpantionary(this string json)
        {
            return json
                ?.FromJson<IList<ExpandoObject>>()
                ?.Cast<IDictionary<string, object>>()
                ?.ToList();
        }
    }
}
