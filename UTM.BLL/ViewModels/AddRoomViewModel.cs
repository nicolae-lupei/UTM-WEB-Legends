using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UTM.BLL.ViewModels
{
    public class AddRoomViewModel
    {
        [Required]
        public virtual string Name { get; set; }
        public virtual int Capacity { get; set; }
        public virtual Guid FloorId { get; set; }
    }
}
