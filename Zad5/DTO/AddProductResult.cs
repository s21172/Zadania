using System.Net;

namespace Zad5.DTO
{
    public class AddProductResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }

        public AddProductResult(HttpStatusCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }    
}
