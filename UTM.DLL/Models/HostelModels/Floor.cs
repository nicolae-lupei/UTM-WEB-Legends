using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UTM.DLL.Models.HostelModels
{
    public class Floor : BaseModel
    {
        [Required]
        public virtual int Number { get; set; }

        public virtual Hostel Hostel { get; set; }
        public virtual Guid HostelId { get; set; }

        public virtual IEnumerable<Room> Rooms { get; set; }
    }
}
