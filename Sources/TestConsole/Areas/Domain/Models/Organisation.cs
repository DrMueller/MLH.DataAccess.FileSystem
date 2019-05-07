﻿using Mmu.Mlh.DomainExtensions.Areas.DomainModeling;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.Domain.Models
{
    public class Organisation : AggregateRoot<string>
    {
        public string Name { get; }

        public Organisation(string name, string id)
           : base(id)
        {
            Guard.StringNotNullOrEmpty(() => name);
            Name = name;
        }
    }
}
