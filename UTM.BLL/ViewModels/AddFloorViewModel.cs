using System;
using System.Collections.Generic;
using System.Text;

namespace UTM.BLL.ViewModels
{
    public class AddFloorViewModel
    {
        public virtual int Number { get; set; }
        public virtual Guid HostelId { get; set; }
    }
}
