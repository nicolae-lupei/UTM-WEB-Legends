using System;
using System.Collections.Generic;

namespace UTM.DLL.Models.CommisionModels
{
    public class Commision : BaseModel
    {
        public virtual string Name { get; set; }

        public  virtual  IEnumerable<CommisionMember> Members { get; set; }

    }
}
