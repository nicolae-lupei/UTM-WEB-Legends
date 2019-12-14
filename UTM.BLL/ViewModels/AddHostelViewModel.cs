using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UTM.BLL.ViewModels
{
    public class AddHostelViewModel
    {
        [Required]
        public virtual string Name { get; set; }
        [Required]
        public virtual int Number { get; set; }
    }
}
