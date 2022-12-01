using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommandService
    {
        void AddCommand(Command command, ReaTask reaTask);
        void RemoveCommand(Command command, int reaTaskId);
        List<CommandLine> List(Command command);
    }
}
