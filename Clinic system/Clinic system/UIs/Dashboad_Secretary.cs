using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_system.UIs
{
    public partial class Dashboad_Secretary : UserControl
    {
        //Secretary s;
        public Dashboad_Secretary(int id)
        {
            InitializeComponent();
            /*foreach (Secretary t in Accounts.AccS)
            {
                if (id == t.ID)
                {
                    s = t;
                    break;
                }
            }*/
        }

        private void Dashboad_Secretary_Load(object sender, EventArgs e)
        {
        }
    }
}
