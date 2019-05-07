using System;
using Mmu.Mlh.DomainExtensions.Areas.DomainModeling;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models
{
    public class Individual : AggregateRoot<string>
    {
        public DateTime Birthdate { get; }
        public string FirstName { get; }
        public string LastName { get; set; }

        public Individual(string firstName, string lastName, DateTime birthdate, string id)
            : base(id)
        {
            Guard.ObjectNotNull(() => firstName);
            Guard.ObjectNotNull(() => lastName);

            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }
    }
}