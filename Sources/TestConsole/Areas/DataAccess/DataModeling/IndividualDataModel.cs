﻿using System;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;

namespace Mmu.Mlh.DataAccess.FileSystem.TestConsole.Areas.DataAccess.DataModeling
{
    public class IndividualDataModel : AggregateRootDataModel<string>
    {
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}