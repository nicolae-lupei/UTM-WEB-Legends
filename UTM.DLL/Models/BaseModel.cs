using System;
using System.Collections.Generic;
using System.Text;

namespace UTM.DLL.Models
{
    public class BaseModel
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual Guid Author { get; set; }
        public virtual DateTime ModifiedBy { get; set; }
    }
}
