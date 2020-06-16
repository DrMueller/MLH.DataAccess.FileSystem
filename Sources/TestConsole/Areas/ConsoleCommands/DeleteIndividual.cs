using System;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class DeleteIndividual : IConsoleCommand
    {
        private readonly IConsoleWriter _consoleWriter;
        private readonly IIndividualRepository _individualRepository;

        public DeleteIndividual(
            IConsoleWriter consoleWriter,
            IIndividualRepository individualRepository)
        {
            _consoleWriter = consoleWriter;
            _individualRepository = individualRepository;
        }

        public string Description => "Delete Individual";

        public ConsoleKey Key => ConsoleKey.D3;

        public async Task ExecuteAsync()
        {
            var allIndividuals = await _individualRepository.LoadAllAsync();
            var individual = allIndividuals.Last();

            await _individualRepository.DeleteAsync(individual.Id);

            _consoleWriter.WriteLine(individual.Id, ConsoleColor.Black, ConsoleColor.Green);
        }
    }
}