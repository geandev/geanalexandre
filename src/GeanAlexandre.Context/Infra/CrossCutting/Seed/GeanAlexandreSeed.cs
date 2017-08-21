using System;
using System.Collections.Generic;
using GeanAlexandre.Context.Domain.Command;
using GeanAlexandre.Context.Domain.CommandHandler;
using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Infra.CrossCutting.Seed
{
    public class GeanAlexandreSeed
    {
        private readonly ICreateResumeCommandHandler _commandHandler;

        public static string Name => "geanalexandre";

        private GeanAlexandreSeed(ICreateResumeCommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
            Execute();
        }

        public static GeanAlexandreSeed Factory(ICreateResumeCommandHandler commandHandler) =>
            new GeanAlexandreSeed(commandHandler);

        private void Execute()
        {
            try
            {
                _commandHandler.ExecuteAsync(new CreateResumeCommand
                {
                    UserName = "geanalexandre",
                        Resume = new Resume
                        {
                            ResumeLanguage = ResumeLanguage.Pt,
                                Header = new Header
                                {
                                    AboutMe = "I am full-stack developer, over 5 years of experience working in development, customization and implementation using .NET, Micro-services and SPA Applications.",
                                        Name = "Gean Alexandre",
                                        Birthday = new DateTime(1994, 07, 29),
                                        PhotoBase64 = "https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAkbAAAAJDY0OWIzNjk4LTE5MzUtNDk0My04NjI3LThhNjhhNjM2NWZlMg.jpg"
                                },
                                Contact = new Contact
                                {
                                    Email = "GeanAlexandre@outook.com",
                                        Facebook = "www.facebook.com/gean4lexandre",
                                        Linkedin = "https://www.linkedin.com/in/gean-alexandre-da-silva-33827b64",
                                        Phone = "19 97415-2939",
                                        Skype = "gean.alexandre"
                                },
                                Educations = new List<Education>
                                {
                                    new Education
                                    {
                                        Place = "People - Microsoft MCSD training",
                                            Year = 2014,
                                            Resume = "I was already working, when I decided to start a training for the MCSD title of microsoft, I already had a great knowledge in the web world, but I was looking for better practices and technologies to solve everyday problems, and it was during this training that I had the opportunity to meet great professionals and in particular the teacher of this course managed to fill a great potential in me, was when he asked my resume for a vacancy in a large company that he was architect SONDAIT, and I passed :)"
                                    },
                                    new Education
                                    {
                                        Place = "IBTA Metrocamp - University",
                                            Year = 2013,
                                            Resume = "I started college, but I wanted something deeper in the development market, so I chose to study a lot myself and do the certification training when it was available, so I decided to pause the college to go back to another stage in my life, and I will finish :)"
                                    },
                                    new Education
                                    {
                                        Place = "People - Technical school in IT",
                                            Year = 2012,
                                            Resume = "I started the technical course to specialize in the IT area, because I already knew what I would like to work with, I was always a positive highlight in the classes, because of my knowledge that I acquired during my studies at home, in this course there was a module completely focused on. ASPNET, and SQL Server, that's how my career began to move into the .NET world"
                                    },
                                    new Education
                                    {
                                        Place = "Maria Invone Martins Rosa - High school",
                                            Year = 2011,
                                            Resume = "It was at school where the passion for programming started, I really liked online games and it was there that I decided to find out how everything works behind the scenes, so I started my first steps with html, I learned a lot of things at that time, like creating websites using html, css and javascript, I gradually evolved creating games lauchers using vb6, so I immersed myself in the .NET world."
                                    }
                                },
                                Experiences = new List<Experience>
                                {
                                    new Experience
                                    {
                                        Place = "Actminds",
                                            BeginYear = 2016,
                                            EndYear = DateTime.Now.Year,
                                            Profession = "Software Developer",
                                            Resume = "Full-stack Software Developer"
                                    },
                                    new Experience
                                    {
                                        Place = "Microsoft",
                                            BeginYear = 2015,
                                            EndYear = 2016,
                                            Profession = "Associate Consultant",
                                            Resume = "Worked in the Rio 2016 Olympic Games Project as a Senior Developer/Engineer. Solution based in 100% Cloud, capable of handling thousands of requests per second. I worked with the development of message processing with game data, resulting in the back end, persisting them in an Azure table, databases and storage in Redis, retrieving this information in the web application AngularJS, ASP.NET MVC. We had a tough quality process, where we have to pass through an internal QA and an external QA direct from the Olympics Committee. I was the responsible for developing backend services and the front-end portal. In addition, among all developers of this project, a few were selected to keep maintaining and supporting it on Games Time. Technologies used: Angular, pattern CQRS, C #, ASP.NET MVC, EntityFramework, Azure Storage, Redis, XML / XSD, Web API, TFS, Git, Visual Studio Online."
                                    },
                                    new Experience
                                    {
                                        Place = "Pearson",
                                            BeginYear = 2014,
                                            EndYear = 2015,
                                            Profession = "Software Development .NET",
                                            Resume = "Worked in project LeadMachine. Wizard, Microlins, People, Quatrum, Skill, Smartz, SOS, Wall Street English and Yazigi franchisees using to launch Leads so that Marketing managers can follow the goals and prospects Franchisees and franchise consultants perform with their clients. For buildind this projects, has been used tecnologies such as ASP.NET Web Forms, Bootstrap, WCF, Web API and Sql Server"
                                    },
                                    new Experience
                                    {
                                        Place = "SondaIT",
                                            BeginYear = 2013,
                                            EndYear = 2014,
                                            Profession = "Systems Analyst",
                                            Resume = "I already had a lot of knowledge on the web, when a teacher from a course got me this opportunity to work in this great SondaIT company (read my profile, education in 2014). I participated directly in the development of the CREANET system, worked on the ART (Annotation of Technical Responsibility) screens, where several technologies, webforms, javascript, jquery, C #, webservices were used, I had the opportunity to work directly on the client for 1 month"
                                    },
                                    new Experience
                                    {
                                        Place = "Infodesk",
                                            BeginYear = 2011,
                                            EndYear = 2012,
                                            Profession = "Programmer Jr",
                                            Resume = "And here was where I really put into practice everything I learned alone and at the technical college, my first challenge was to create a helpdesk systems, where I remember using technologies like MVC, Razor (View engine), SignalR, javascript, html, css, web api ... is still working support.infodesk.com.br"
                                    },
                                    new Experience
                                    {
                                        Place = "EgonCred",
                                            BeginYear = 2011,
                                            EndYear = 2012,
                                            Profession = "Administrative Assistant",
                                            Resume = "I started as an administrative assistant but I was also the IT guy, did software updates, system configuration, etc ..."
                                    }
                                },
                                Skills = new List<Skill>
                                {
                                    new Skill
                                    {
                                        Label = "Microservices",
                                            Level = SkillLevel.Master,
                                    },
                                    new Skill
                                    {
                                        Label = ".NET",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "C#",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "Single Page Application (SPA)",
                                            Level = SkillLevel.Master

                                    },
                                    new Skill
                                    {
                                        Label = "JavaScript",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "TypeScript",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "HTML",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "CSS",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "ANGULAR 1.x",
                                            Level = SkillLevel.Master
                                    },
                                    new Skill
                                    {
                                        Label = "ANGULAR 4",
                                            Level = SkillLevel.Expert
                                    },
                                    new Skill
                                    {
                                        Label = "Docker",
                                            Level = SkillLevel.Proficient
                                    }
                                },
                                Languages = new List<Language>
                                {
                                    new Language
                                    {
                                        Name = "Portuguese",
                                            Percent = 100
                                    },
                                    new Language
                                    {
                                        Name = "English",
                                            Percent = 80
                                    }
                                },
                                Tags = new string[]
                                {
                                    "C#",
                                    "SQL SERVER",
                                    "JavaScript",
                                    "ASP.NET",
                                    "JQuery",
                                    "HTML",
                                    "XML",
                                    "CSS",
                                    "MVC",
                                    "JAVA",
                                    "MySQL",
                                    "Azure",
                                    "Aws",
                                    "S.O.L.I.D",
                                    "Microservices",
                                    "Docker",
                                    "Scrum",
                                    "SPA",
                                    "Angular",
                                    "Typescript",
                                    "DevOps",
                                    "Design Pattern",
                                    "Webpack",
                                    "Gulp",
                                    "Db2",
                                    "Blockchain",
                                    "MongoDB",
                                    "RavenDB",
                                    "DocumentDB",
                                    "PWA",
                                    "ServiceWorker",
                                    "Continuous Delivery",
                                    "WindowsForms",
                                    "WebForms",
                                    "DDD",
                                    "TDD",
                                    "Unit Test",
                                    "TFS",
                                    "GIT",
                                    "Visual Studio",
                                    "Visual Studio Code",
                                    "Rider JetBrains",
                                    "Intellij",
                                    "Linux",
                                    "Windows"
                                }
                        }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}