using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<ReaTask> ReaTasks { get; set; } 
    }
}
