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
    public partial class Dashboard_Pharmacist : UserControl
    {
        Pharmacist ph;
        public Dashboard_Pharmacist(int id)
        {
            InitializeComponent();
            foreach (Pharmacist t in Accounts.AccPh)
            {
                if (id == t.ID)
                {
                    ph = t;
                    break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Pharmacist_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            bool ndone = true;
            foreach(List<string> t in Medecine.mOut)
            {
                if (t[0] == s)
                {
                    foreach(List<string> u in Medecine.mIn)
                    {
                        if (t[1] == u[0])
                        {
                            if (Convert.ToInt32(t[2]) <= Convert.ToInt32(u[1]))
                            {
                                u[1] = Convert.ToString(Convert.ToInt32(u[1]) - Convert.ToInt32(t[2]));
                                Medecine.mOut.Remove(t);
                                ndone = false;
                                textBox1.Text = "";
                                break;
                            }
                        }
                    }
                }
                if (!ndone)
                    break;
            }
            if (ndone)
            {
                MessageBox.Show("Error!");
            }
            refresh();
        }

        void refresh()
        {
            bunifuCircleProgressbar2.Value = ph.percentMedecine();
            listView1.Items.Clear();
            listView2.Items.Clear();
            foreach (List<string> t in Medecine.mIn)
            {
                var row = new string[] { t[0], t[1] };
                var x = new ListViewItem(row);
                listView1.Items.Add(x);
            }
            foreach (List<string> t in Medecine.mOut)
            {
                var row = new string[] { t[0], t[1], t[2] };
                var x = new ListViewItem(row);
                listView2.Items.Add(x);
            }
        }
    }
}
