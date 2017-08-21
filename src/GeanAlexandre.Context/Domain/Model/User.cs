using System;
using System.Collections.Generic;
using System.Linq;
using GeanAlexandre.Context.Domain.Model.Builder;
using GeanAlexandre.Context.Domain.Validation;


namespace GeanAlexandre.Context.Domain.Model
{
    public class User
    {
        public User(IUserBuilder builder)
        {
            Id = Guid.NewGuid();
            UserName = builder.UserName;
            Resumes = new List<Resume>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public IList<Resume> Resumes { get; set; }


        public User CreateNewResume(Resume resume)
        {
            FluentValidation<IList<Resume>>
                .Validate(Resumes)
                .ThrowCase(resumes => resumes.Any(r => r.ResumeLanguage.Equals(resume.ResumeLanguage)),
                    $"User.CreateNewResume({resume.ResumeLanguage}) already exists")
                .Else(() => Resumes.Add(resume));

            return this;
        }
    }
}