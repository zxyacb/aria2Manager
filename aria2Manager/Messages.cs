using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace aria2Manager
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BaseMessage
    {
        [JsonProperty(PropertyName = "jsonrpc")]
        public string JsonRPC = "2.0";

        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id;

        [JsonProperty(PropertyName = "method")]
        public Aria2Method Method;

        [JsonProperty(PropertyName = "params")]
        public string[] Params;
    }
    
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Aria2Method
    {
        [EnumMember(Value = "aria2.addUri")]
        AddUri,
        [EnumMember(Value = "aria2.getFiles")]
        GetFiles,
        [EnumMember(Value = "aria2.getUris")]
        GetUris
    }
}
