using System.ComponentModel.DataAnnotations;

namespace UTM.DLL.Models.Requests
{
    public class RequestType : BaseModel
    {
        [Required]
        public virtual string Name { get; set; }
    }
}
