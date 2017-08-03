using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WorkFlowDesigner
{
    public class User
    {
        private int id_user;
        private String surname;
        private String name;
        private String permission;


        [DisplayName(@"Id_User")]
        public virtual int Id_user { get => id_user; set => id_user = value; }
        [DisplayName(@"Surname")]
        public virtual string Surname { get => surname; set => surname = value; }
        [DisplayName(@"Name")]
        public virtual string Name { get => name; set => name = value; }
        [DisplayName(@"Permission.")]
        public virtual string Permission { get => permission; set => permission = value; }
    }
}
