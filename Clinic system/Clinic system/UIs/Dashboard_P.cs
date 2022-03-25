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
    public partial class Dashboard_P : UserControl
    {
        Patient p;
        public Dashboard_P(int id)
        {
            InitializeComponent();
            foreach (Patient t in Accounts.AccP)
            {
                if(id == t.ID)
                {
                    p = t;
                    break;
                }
            }
        }

        private void Dashboard_P_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel10.Text = p.name;
            bunifuCustomLabel8.Text = Convert.ToString( p.Age);
            bunifuCustomLabel6.Text = p.phone;
            bunifuCustomLabel4.Text = p.appointments;
        }
    }
}
