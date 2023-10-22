using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Grant_Management_System.Models.DropdownMenus
{
    public class Duration:BaseDomaininEntity
    {
        [Display(Name = "Duration")]
        public string Name { get; set; }
        public virtual List<Grant> Grants { get; set; }

        public static implicit operator Duration(string v)
        {
            throw new NotImplementedException();
        }
    }
}
