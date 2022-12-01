using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommandManager : ICommandService
    {
        public void AddCommand(Command command, ReaTask reaTask)
        {
            CommandLine commandLine = command.CommandLines.FirstOrDefault(c => c.ReaTask.ReaTaskId == reaTask.ReaTaskId);
            if (commandLine != null)
            {
                commandLine.Message="yorum";
                return;
            }
            else
            {
                command.CommandLines.Add(new CommandLine { ReaTask = reaTask, Message = "" });
            }
        }

        public List<CommandLine> List(Command command)
        {
            return command.CommandLines.ToList();
        }

        public void RemoveCommand(Command command, int reaTaskId)
        {
            command.CommandLines.Remove(command.CommandLines.FirstOrDefault(c=>c.ReaTask.ReaTaskId==reaTaskId));
        }
    }
}
