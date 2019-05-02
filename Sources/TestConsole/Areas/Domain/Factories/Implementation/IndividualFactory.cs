using System;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories.Implementation
{
    public class IndividualFactory : IIndividualFactory
    {
        public Individual Create(string firstName, string lastName, DateTime birthdate, long? id = null)
        {
            return new Individual(
                id ?? 0,
                firstName,
                lastName,
                birthdate);
        }
    }
}