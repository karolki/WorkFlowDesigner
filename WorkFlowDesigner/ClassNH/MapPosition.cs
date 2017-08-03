using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace WorkFlowDesigner
{
    

        public class MapPosition : ClassMapping<Position>
    {
        public MapPosition() { 

            Table("Position");
            Id(x => x.Id_position , m => { m.Column("id_position"); m.Generator(Generators.Identity); });
            Property(x =>x.Name, m => { m.Column("name"); });
            ManyToOne(x => x.Id_flow, m => {
                m.Column("id_flow");
                 });

        }
    }
}
