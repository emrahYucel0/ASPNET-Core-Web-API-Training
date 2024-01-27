using System.ComponentModel.DataAnnotations;

namespace WebAPIExample.Models
{
    public class ResponseModel
    {
        public int HTTPStatus { get; set; }
        
        public string? Message { get; set; }
    }
}
