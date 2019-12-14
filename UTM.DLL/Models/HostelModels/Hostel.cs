using System;
using System.Collections.Generic;
using System.Text;

namespace UTM.DLL.Models.HostelModels
{
    public class Hostel : BaseModel
    {
        public virtual string Name { get; set; }
        public virtual int Number { get; set; }
        public virtual IEnumerable<Floor> Floors { get; set; }
    }
}
