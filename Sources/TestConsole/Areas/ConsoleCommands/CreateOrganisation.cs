﻿using System;
using System.Threading.Tasks;
using Mmu.Mlh.ConsoleExtensions.Areas.Commands.Models;
using Mmu.Mlh.ConsoleExtensions.Areas.ConsoleOutput.Services;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Repositories;
using Newtonsoft.Json;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.ConsoleCommands
{
    public class CreateOrganisation : IConsoleCommand
    {
        private static readonly Random Random = new Random();

        private readonly IConsoleWriter _consoleWriter;
        private readonly IOrganisationRepository _organisationRepo;
        private readonly IOrganisationFactory _organisationFactory;

        public string Description => "Create Organisation";

        public ConsoleKey Key => ConsoleKey.D5;

        public CreateOrganisation(
            IConsoleWriter consoleWriter,
            IOrganisationRepository organisationRepo,
            IOrganisationFactory organisationFactory)
        {
            _consoleWriter = consoleWriter;
            _organisationRepo = organisationRepo;
            _organisationFactory = organisationFactory;
        }

        public async Task ExecuteAsync()
        {
            var organisation = _organisationFactory.Create("Test Name " + Random.Next(1, 1000));
            var savedOrganisation = await _organisationRepo.SaveAsync(organisation);

            _consoleWriter.WriteLine(JsonConvert.SerializeObject(savedOrganisation), ConsoleColor.Black, ConsoleColor.Green);
        }
    }
}
