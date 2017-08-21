using System;

namespace GeanAlexandre.Context.Domain.Model
{
    public class Header
    {
        public string PhotoBase64 { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int YearsOld => DateTime.Now.Year - Birthday.Year;
        public string AboutMe { get; set; }
    }
}