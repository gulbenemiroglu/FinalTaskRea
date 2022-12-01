using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    
    public class ReaTask
    {
        [Key]
        public int ReaTaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
        

    }
}
