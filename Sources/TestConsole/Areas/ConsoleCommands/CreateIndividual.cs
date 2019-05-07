using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class CreateIndividual : IConsoleCommand
    {
        private static readonly Random Random = new Random();

        private readonly IConsoleWriter _consoleWriter;
        private readonly IIndividualRepository _individualRepo;
        private readonly IIndividualFactory _individualFactory;

        public CreateIndividual(
            IConsoleWriter consoleWriter,
            IIndividualRepository individualRepo,
            IIndividualFactory individualFactory)
        {
            _consoleWriter = consoleWriter;
            _individualRepo = individualRepo;
            _individualFactory = individualFactory;
        }

        public string Description { get; } = "Create Individual";
        public ConsoleKey Key { get; } = ConsoleKey.D1;

        public async Task ExecuteAsync()
        {
            var individual = _individualFactory.Create(
                "Matthias " + Random.Next(1, 100),
                "Müller " + Random.Next(1, 100),
                new DateTime(1986, 12, 29));

            var savedIndividual = await _individualRepo.SaveAsync(individual);
            _consoleWriter.WriteLine(JsonConvert.SerializeObject(savedIndividual), ConsoleColor.Black, ConsoleColor.Green);
        }
    }
}