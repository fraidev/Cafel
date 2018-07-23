using System;
using System.Collections.Generic;

namespace Cafel.WebApi.Domain
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Username { get; set; }
        public virtual string Passworld { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual DateTime AccountCreated { get; set; }
        public virtual List<Content> Content {get; set; }
        public User()
        {
        }
        
        public User(string name, string username, string passworld, DateTime birthDate)
        {
            Id = new Guid();
            Name = name;
            Username = username;
            Passworld = passworld;
            BirthDate = birthDate.Date;
            AccountCreated = DateTime.Now;
        }
    }
}