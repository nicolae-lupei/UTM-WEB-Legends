using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UTM.DLL.Models.HostelModels
{
    public class Room : BaseModel
    {
        [Required]
        public virtual string Name { get; set; }
        public virtual int Capacity { get; set; }
        public virtual  IEnumerable<RoomInventory> RoomInventories { get; set; }
    }
}
