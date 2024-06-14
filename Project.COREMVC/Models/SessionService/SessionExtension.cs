using Newtonsoft.Json;


namespace Project.COREMVC.Models.SessionService
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string objectString = session.GetString(key);
            if (!string.IsNullOrEmpty(objectString))
            {
                T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
                return deserializedObject;
            }
            return null;
        }

        public static void SetCookie(this HttpResponse response, string key, object value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMinutes(30);

            var jsonValue = JsonConvert.SerializeObject(value);
            response.Cookies.Append(key, jsonValue, option);
        }

        public static T GetCookie<T>(this HttpRequest request, string key)
        {
            var cookie = request.Cookies[key];
            return cookie == null ? default(T) : JsonConvert.DeserializeObject<T>(cookie);
        }

    }
}
