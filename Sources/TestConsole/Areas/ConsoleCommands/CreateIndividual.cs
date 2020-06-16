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
        private static readonly Random _random = new Random();

        private readonly IConsoleWriter _consoleWriter;
        private readonly IIndividualFactory _individualFactory;
        private readonly IIndividualRepository _individualRepo;

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
                "Matthias " + _random.Next(1, 100),
                "Müller " + _random.Next(1, 100),
                new DateTime(1986, 12, 29));

            var savedIndividual = await _individualRepo.SaveAsync(individual);
            _consoleWriter.WriteLine(JsonConvert.SerializeObject(savedIndividual), ConsoleColor.Black, ConsoleColor.Green);
        }
    }
}