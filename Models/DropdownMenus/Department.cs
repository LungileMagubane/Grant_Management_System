using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Grant_Management_System.Models.DropdownMenus
{
    public class Department:BaseDomaininEntity
    {
        [Display(Name= "Department")]
        public string Name { get; set;}
        public virtual List<Grant> Grants { get; set; }
    }
}
