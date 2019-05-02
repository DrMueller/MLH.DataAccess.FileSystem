using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.Repositories;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class CreateFile : IConsoleCommand
    {
        private readonly IConsoleWriter _consoleWriter;
        private readonly IIndividualRepository _individualRepo;
        private readonly IIndividualFactory _individualFactory;

        public CreateFile(
            IConsoleWriter consoleWriter,
            IIndividualRepository individualRepo,
            IIndividualFactory individualFactory)
        {
            _consoleWriter = consoleWriter;
            _individualRepo = individualRepo;
            _individualFactory = individualFactory;
        }

        public string Description { get; } = "Create File";
        public ConsoleKey Key { get; } = ConsoleKey.D1;

        public async Task ExecuteAsync()
        {
            var individual = _individualFactory.Create("Matthias", "Müller", new DateTime(1986, 12, 29));
            var savedIndividual = await _individualRepo.SaveAsync(individual);
            _consoleWriter.WriteLine(JsonConvert.SerializeObject(savedIndividual), ConsoleColor.Black, ConsoleColor.Green);
        }
    }
}