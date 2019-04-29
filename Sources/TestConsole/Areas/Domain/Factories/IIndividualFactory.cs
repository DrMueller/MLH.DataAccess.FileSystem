using System;
using Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Factories
{
    public interface IIndividualFactory
    {
        Individual Create(string firstName, string lastName, DateTime birthdate, long? id = null);
    }
}