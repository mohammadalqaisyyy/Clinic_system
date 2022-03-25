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
    public partial class report_doctor : UserControl
    {
        int id_;
        public report_doctor(int id)
        {
            InitializeComponent();
            id_ = id;
        }

        private void report_doctor_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (List<string> t in reports.Reports)
            {
                comboBox1.Items.Add(t[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (List<string> t in reports.Reports)
            {
                if (comboBox1.Text == t[0])
                {
                    t[1] = richTextBox1.Text;
                    t[2] = textBox2.Text;
                    t[3] = comboBox2.Text;
                    List<string> m = new List<string> { comboBox1.Text, textBox2.Text, comboBox2.Text };
                    Medecine.mOut.Add(m);
                    richTextBox1.Text="";
                    textBox2.Text="";
                    comboBox2.Text="";
                }
            }
        }
    }
}
