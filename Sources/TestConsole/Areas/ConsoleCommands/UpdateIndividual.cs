using System;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class UpdateIndividual : IConsoleCommand
    {
        private readonly IConsoleWriter _consoleWriter;
        private readonly IIndividualRepository _individualRepository;

        public UpdateIndividual(
            IConsoleWriter consoleWriter,
            IIndividualRepository individualRepository)
        {
            _consoleWriter = consoleWriter;
            _individualRepository = individualRepository;
        }

        public string Description => "Update Individual";

        public ConsoleKey Key => ConsoleKey.D2;

        public async Task ExecuteAsync()
        {
            var allIndividuals = await _individualRepository.LoadAllAsync();
            var individual = allIndividuals.First();
            individual.LastName = "Updated " + individual.LastName;
            var updatedIndividual = await _individualRepository.SaveAsync(individual);

            _consoleWriter.WriteLine(JsonConvert.SerializeObject(updatedIndividual), ConsoleColor.Black, ConsoleColor.Green);
        }
    }
}