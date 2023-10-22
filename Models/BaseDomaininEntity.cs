using System.ComponentModel.DataAnnotations;

namespace Grant_Management_System.Models
{
    public abstract  class BaseDomaininEntity
    {
        [Key]
        public int? Id { get; set; }
    }
}
