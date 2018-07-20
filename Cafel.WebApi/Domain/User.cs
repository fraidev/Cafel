using System;
using System.Collections.Generic;

namespace Cafel.WebApi.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Passworld { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AccountCreated { get; set; }
        public List<Content> Content {get; set; }

        public User(string name, string username, string passworld, DateTime birthDate)
        {
            Id = new Guid();
            Name = name;
            Username = username;
            Passworld = passworld;
            BirthDate = birthDate;
            AccountCreated = new DateTime();
        }
    }
}