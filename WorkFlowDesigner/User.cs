using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowDesigner
{
    class User
    {
        private int id_user;
        private String surname;
        private String name;
        private String permission;

        public User(int id_user, string surname, string name, string permission)
        {
            this.id_user = id_user;
            this.surname = surname;
            this.name = name;
            this.permission = permission;
        }

        public User()
        {
            this.id_user = 0;
            this.surname = "";
            this.name = "";
            this.permission = "";
        }

        public int Id_user { get => id_user; set => id_user = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Permission { get => permission; set => permission = value; }
    }
}
