using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_system
{

    public class Doctor
    {
        public int ID, roomNumber;
        public string name, major, password;
        public List<int> appointments = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        public Doctor(int ID, string name, string major, string password, int roomNumber)
        {
            this.ID = ID;
            this.name = name;
            this.major = major;
            this.password = password;
            this.roomNumber = roomNumber;
        }

    }
}
