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
    public partial class Dashboard_Manager : UserControl
    {
        Manager m = Manager.GetManager();
        public Dashboard_Manager()
        {
            InitializeComponent();
        }

        private void Dashboard_Manager_Load(object sender, EventArgs e)
        {
            Pharmacist ph = new Pharmacist(2, "Baraa","b50",2);
            bunifuCircleProgressbar2.Value = ph.percentMedecine();
            bunifuCustomLabel10.Text = m.Name;
            bunifuCustomLabel2.Text= Convert.ToString(m.ID);
            bunifuCustomLabel8.Text = Convert.ToString(Accounts.AccD.Count());
            bunifuCustomLabel9.Text = Convert.ToString(Accounts.AccP.Count());
            bunifuCustomLabel11.Text = Convert.ToString(Accounts.AccPh.Count());
            
        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
