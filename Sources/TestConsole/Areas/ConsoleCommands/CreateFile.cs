using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class CreateFile : IConsoleCommand
    {
        public CreateFile()
        {
            
        }

        public string Description { get; } = "Create File";
        public ConsoleKey Key { get; } = ConsoleKey.D1;

        public Task ExecuteAsync()
        {
        }
    }
}