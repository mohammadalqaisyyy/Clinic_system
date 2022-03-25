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
    public partial class Dashboard_Doctor : UserControl
    {
        Doctor d;
        public Dashboard_Doctor(int id)
        {
            InitializeComponent();
            foreach (Doctor t in Accounts.AccD)
            {
                if (id == t.ID)
                {
                    d = t;
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Doctor_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel10.Text = d.name;
            bunifuCustomLabel2.Text = Convert.ToString(d.ID);
        }
    }
}
