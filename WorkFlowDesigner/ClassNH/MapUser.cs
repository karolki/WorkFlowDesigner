using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WorkFlowDesigner
{
    public class MapUser : ClassMapping<User>
    {
        public MapUser()
        {

            Table("Users");
            Id(x => x.Id_user, m => { m.Column("id_user"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });
            Property(x => x.Surname, m => { m.Column("surname"); });
            Property(x => x.Permission, m => { m.Column("permission"); });
            Property(x => x.Password, m => { m.Column("password"); });

            ManyToOne(x => x.Id_position, m =>
            {
                m.Column("id_position");
            });
            Bag(x => x.DocumentList, m =>
            {
                m.Inverse(true); m.Key(k => k.Column("id_user"));

            }, r => r.OneToMany(x => x.Class(typeof(Document))));


        }
    }
}