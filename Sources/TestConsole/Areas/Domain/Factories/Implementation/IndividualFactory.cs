using System;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories.Implementation
{
    public class IndividualFactory : IIndividualFactory
    {
        public Individual Create(string firstName, string lastName, DateTime birthdate, string id = null)
        {
            return new Individual(
                firstName,
                lastName,
                birthdate,
                id);
        }
    }
}