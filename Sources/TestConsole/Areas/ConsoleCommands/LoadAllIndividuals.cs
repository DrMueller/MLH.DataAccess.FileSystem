using System;
using System.Text;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class LoadAllIndividuals : IConsoleCommand
    {
        private readonly IConsoleWriter _consoleWriter;
        private readonly IIndividualRepository _individualRepository;

        public string Description => "Load all Individuals";

        public ConsoleKey Key => ConsoleKey.D4;

        public LoadAllIndividuals(
            IConsoleWriter consoleWriter,
            IIndividualRepository individualRepository)
        {
            _consoleWriter = consoleWriter;
            _individualRepository = individualRepository;
        }

        public async Task ExecuteAsync()
        {
            var allIndividuals = await _individualRepository.LoadAllAsync();
            var sb = new StringBuilder();

            foreach (var individual in allIndividuals)
            {
                sb.AppendLine(JsonConvert.SerializeObject(individual));
                sb.AppendLine();
            }

            _consoleWriter.Write(sb.ToString(), ConsoleColor.Black, ConsoleColor.White);
        }
    }
}
