using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Grant_Management_System.Models.DropdownMenus
{
    public class Race : BaseDomaininEntity
    {
        [Display(Name = "Race")]
        public string Name { get; set; }
        public virtual List<Grant> Grants { get; set; }
    }
}
