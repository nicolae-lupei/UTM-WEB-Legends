using System.Collections.Generic;

namespace UTM.DLL.Models.HostelModels
{
    public class Floor : BaseModel
    {
        public virtual int Number { get; set; }

        public virtual IEnumerable<Room> Rooms { get; set; }
    }
}
