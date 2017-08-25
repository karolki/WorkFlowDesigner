using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowDesigner.ClassDatabase;

namespace WorkFlowDesigner
{
    class MapDatabaseConnection : ClassMapping<DatabaseConnection>
    {
        public MapDatabaseConnection()
        {
            Table("DatabaseConnection");
            Id(x=>x.Id_connection, m => { m.Column("id_connection"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });
            Property(x => x.Server, m => { m.Column("server"); });
            Property(x => x.Database, m => { m.Column("database"); });
            Property(x => x.UserName, m => { m.Column("user_name"); });
            Property(x => x.Password, m => { m.Column("password"); });
        }
    }
}
