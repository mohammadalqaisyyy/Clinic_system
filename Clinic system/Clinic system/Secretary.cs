using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_system
{
    public class Secretary
    {
        public int ID;
        public string name, password;

        public Secretary(int id, string name,string password)
        {
            this.ID = id;
            this.name = name;
            this.password = password;
        }

    }
}
