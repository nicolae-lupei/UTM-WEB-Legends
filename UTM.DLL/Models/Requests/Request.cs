using System;

namespace UTM.DLL.Models.Requests
{
    public class Request : BaseModel
    {
        public virtual RequestType RequestType { get; set; }
        public virtual Guid RequestId { get; set; }

        public virtual User User { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual RequestState RequestState { get; } = RequestState.New;
    }
}
