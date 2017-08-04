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
            ManyToOne(x => x.Id_flow, m =>
            {
                m.Column("id_flow");
                Bag(x => x.StartStepList, mc =>
                {
                    mc.Inverse(true); mc.Key(k => k.Column("start_position_id"));

                }, r => r.OneToMany(x => x.Class(typeof(Position))));
                Bag(x => x.EndStepList, mc =>
                {
                    mc.Inverse(true); mc.Key(k => k.Column("end_position_id"));

                }, r => r.OneToMany(x => x.Class(typeof(Position))));
            });

        }

    }
}
