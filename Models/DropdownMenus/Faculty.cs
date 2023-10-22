using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Grant_Management_System.Models.DropdownMenus
{
    public class Faculty:BaseDomaininEntity
    {
        [Display(Name = "Faculty")]
        public string Name { get; set; }
        public virtual List<Grant> Grants { get; set; }
    }
}
