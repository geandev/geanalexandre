using System;
using System.Collections.Generic;
using GeanAlexandre.Context.Domain.Model.Builder;

namespace GeanAlexandre.Context.Domain.Model
{
    public class Resume
    {
        public ResumeLanguage ResumeLanguage { get; set; }
        public Header Header { get; set; }
        public Contact Contact { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public string[] Tags { get; set; }
    }
}