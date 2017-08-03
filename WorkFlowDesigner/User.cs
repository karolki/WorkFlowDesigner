using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WorkFlowDesigner
{
    class User
    {
        private int id_user;
        private String surname;
        private String name;
        private String permission;


        [DisplayName(@"Id_User")]
        public int Id_user { get => id_user; set => id_user = value; }
        [DisplayName(@"Surname")]
        public string Surname { get => surname; set => surname = value; }
        [DisplayName(@"Name")]
        public string Name { get => name; set => name = value; }
        [DisplayName(@"Permission.")]
        public string Permission { get => permission; set => permission = value; }
    }
}
