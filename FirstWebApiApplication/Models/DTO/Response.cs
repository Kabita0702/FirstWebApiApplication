using System.Net;

namespace FirstWebApiApplication.Models.DTO
{
    public class Response
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}
