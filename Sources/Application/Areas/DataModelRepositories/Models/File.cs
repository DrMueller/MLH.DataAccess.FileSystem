﻿using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.DataAccess.FileSystem.Areas.DataModelRepositories.Models
{
    public class File
    {
        public string Content { get; }
        public string FileName { get; }

        public File(string fileName, string content)
        {
            Guard.StringNotNullOrEmpty(() => fileName);

            FileName = fileName;
            Content = content;
        }
    }
}