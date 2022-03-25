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
    public partial class Edit_Patient : UserControl
    {
        int id_;
        public Edit_Patient(int id)
        {
            InitializeComponent();
            id_ = id;
        }

        private void Edit_Patient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Patient t in Accounts.AccP)
            {
                if (id_ == Convert.ToInt32(t.ID))
                {
                    t.name = textBox1.Text;
                    t.password = textBox4.Text;
                    t.phone = textBox8.Text;
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox8.Text = "";
                    MessageBox.Show("Done ^_^");
                }
            }
        }
    }
}
