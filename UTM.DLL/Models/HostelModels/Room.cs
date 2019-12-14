using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UTM.DLL.Models.HostelModels
{
    public class Room : BaseModel
    {
        [Required]
        public virtual string Name { get; set; }
        public virtual int Capacity { get; set; }
        public  virtual  Floor Floor { get; set; }
        public  virtual  Guid FloorId { get; set; }
        public virtual  IEnumerable<RoomInventory> RoomInventories { get; set; }
    }
}
