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
    public partial class view_report : UserControl
    {
        int id_;
        string type = "d";
        public view_report(int id)
        {
            InitializeComponent();
            id_ = id;
            foreach(Patient t in Accounts.AccP)
            {
                if(id == Convert.ToInt32(t.ID))
                {
                    type = "p";
                    comboBox2.Enabled = false;
                }
            }
        }

        private void view_report_Load(object sender, EventArgs e)
        {
            if (type == "p")
            {
                foreach (List<string> t in reports.Reports)
                {
                    if (id_ == Convert.ToInt32(t[0]))
                    {
                        comboBox2.Text = t[0];
                        richTextBox1.Text = t[1];
                        textBox2.Text = t[2];
                        textBox1.Text = t[3];
                    }
                }
            }
            else if (type == "d")
            {
                comboBox2.Items.Clear();
                foreach (List<string> t in reports.Reports)
                {
                    comboBox2.Items.Add(t[0]);
                }
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            foreach (List<string> t in reports.Reports)
            {
                if (comboBox2.Text == t[0])
                {
                    richTextBox1.Text = t[1];
                    textBox2.Text = t[2];
                    textBox1.Text = t[3];
                }
            }
        }
    }
}
