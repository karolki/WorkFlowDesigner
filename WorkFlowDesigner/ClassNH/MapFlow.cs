using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace WorkFlowDesigner
{
    class MapFlow:ClassMapping<Flow>
    {
        public MapFlow() {
            Table("WorkFlow");
            Id(x => x.Flow_id, m => { m.Column("flow_id"); m.Generator(Generators.Identity); });
            Property(x => x.Flow_name, m => { m.Column("flow_name"); });
            Property(x => x.Flow_description, m => { m.Column("flow_description"); });


            Bag(x => x.PositionList, m =>
            {
                m.Inverse(true); m.Key(k => k.Column("flow_id"));

            }, r => r.OneToMany(x => x.Class(typeof(Position))));
        }
    }
}
