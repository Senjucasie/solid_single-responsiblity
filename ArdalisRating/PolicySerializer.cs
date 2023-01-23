using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ArdalisRating
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policyjson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyjson,
                new StringEnumConverter()); ;
        }
    }
}
