using System;

namespace UTM.DLL.Models.CommisionModels
{
    public class CommisionMember : BaseModel
    {
        public virtual User User { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual Role Role { get; set; }
        public virtual Guid RoleId { get; set; }
    }
}
