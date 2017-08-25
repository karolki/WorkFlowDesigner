using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner.ClassDatabase
{
    public class Source
    {
        public virtual int Id_source { get; set; }
        public virtual DatabaseConnection Id_database { get; set; }
        public virtual string TableName { get; set; }
        public virtual Attributes Id_attribute { get; set; }
        public virtual string ColumnName { get; set; }
    }
}
