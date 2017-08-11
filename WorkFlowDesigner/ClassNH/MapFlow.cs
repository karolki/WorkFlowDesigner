using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace WorkFlowDesigner
{
    class MapFlow : ClassMapping<Flow>
    {
        public MapFlow()
        {
            Table("Flow");
            Id(x => x.id_flow, m => { m.Column("id_flow"); m.Generator(Generators.Identity); });
            Property(x => x.Name, m => { m.Column("name"); });
            
            ManyToOne(x => x.id_user, m =>
            {
                m.Column("id_user");
            });

            ManyToOne(x => x.id_position, m =>
            {
                m.Column("id_position");
            });


            ManyToOne(x => x.id_flowdefinition, m =>
            {
                m.Column("id_workflowdefinition");
            });

            Bag(x => x.FlowExtensionList, m =>
            {
                m.Inverse(true); m.Key(k => k.Column("id_flow"));

            }, r => r.OneToMany(x => x.Class(typeof(FlowExtension))));
        }
    }
}