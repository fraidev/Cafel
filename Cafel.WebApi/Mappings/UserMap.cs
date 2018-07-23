using Cafel.WebApi.Domain;
using FluentNHibernate.Mapping;

namespace Cafel.WebApi.Mappings
{
    public class UserMap: ClassMap<User>
    {
        public UserMap()
        {
            Table("[Users]");
            
            Id(x => x.Id);
            
            Map(x => x.Name);
            Map(x => x.Username);
            Map(x => x.Passworld);
            Map(x => x.AccountCreated);
            
            /*
            HasManyToMany(x => x.Content)
                .Cascade.All()
                .Inverse()
                .Table("Content");*/
        }
    }
}