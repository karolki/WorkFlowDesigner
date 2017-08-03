using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WorkFlowDesigner
{
   public  class MapUser:ClassMapping<User>
    {
        public  MapUser()
        {

            Table("Users123");
            Id(x => x.Id_user, m => { m.Column("id_user"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });
            Property(x => x.Surname, m => { m.Column("surname"); });
            Property(x => x.Permission, m => { m.Column("permission"); });


        }
    }
}
