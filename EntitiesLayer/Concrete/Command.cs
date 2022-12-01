using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Concrete
{
    public class Command
    {
        public Command()
        {
            CommandLines = new List<CommandLine>();
        }
        public List<CommandLine> CommandLines { get; set; }
       
    }
}
