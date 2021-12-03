using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandName = inputArgs[0] + "Command";
            string[] parameters = inputArgs.Skip(1).ToArray();

            var type = Assembly.GetCallingAssembly().GetTypes().Where(x => x.Name == commandName).FirstOrDefault();

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command");
            }
            ICommand command = Activator.CreateInstance(type) as ICommand;

            string result = command.Execute(parameters);
            return result;

        }
    }
}
