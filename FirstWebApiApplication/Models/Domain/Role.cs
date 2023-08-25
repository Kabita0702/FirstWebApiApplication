using System.Text.Json.Serialization;

namespace FirstWebApiApplication.Models.Domain
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Student,
        Employee,
    }
}
