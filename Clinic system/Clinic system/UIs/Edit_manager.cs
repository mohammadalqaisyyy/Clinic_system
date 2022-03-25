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
    public partial class Edit_manager : UserControl
    {
        Manager m = Manager.GetManager();
        public Edit_manager()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edit_manager_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Doctor")
            {
                try
                {
                    m.addDoctor(textBox3.Text, textBox4.Text, textBox8.Text, Convert.ToInt32(textBox7.Text));
                    //Doctor p = new Doctor(Convert.ToInt32(textBox1.Text), textBox3.Text, textBox4.Text, textBox8.Text,Convert.ToInt32( textBox7.Text));
                    //Accounts.AccD.Add(p);
                }
                catch
                {
                    MessageBox.Show("Error info!");
                }
            }
            if (comboBox1.Text == "Pharmacist")
            {
                try
                {
                    m.addPharmacist(textBox3.Text, textBox4.Text, Convert.ToInt32(textBox8.Text));
                    //Pharmacist p = new Pharmacist(Convert.ToInt32(textBox1.Text), textBox3.Text, textBox4.Text, Convert.ToInt32(textBox8.Text));
                    //Accounts.AccPh.Add(p);
                }
                catch
                {
                    MessageBox.Show("Error info!");
                }
            }
            /*if (comboBox1.Text == "Secretary")
            {
                try
                {
                    Secretary p = new Secretary(Convert.ToInt32(textBox1.Text), textBox3.Text, textBox4.Text);
                    Accounts.AccS.Add(p);
                }
                catch
                {
                    MessageBox.Show("Error info!");
                }
            }*/
            if (comboBox1.Text == "Patient")
            {
                try
                {
                    m.addPatient(textBox3.Text, Convert.ToInt32(textBox8.Text), textBox4.Text, textBox7.Text);
                    //Patient p = new Patient(Convert.ToInt32(textBox1.Text), textBox3.Text, Convert.ToInt32(textBox8.Text), textBox4.Text, textBox7.Text);
                    //Accounts.AccP.Add(p);
                }
                catch
                {
                    MessageBox.Show("Error info!");
                }
            }
            refresh();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Doctor")
            {
                bunifuCustomLabel9.Text = "Major:";
                bunifuCustomLabel8.Text = "Room Number:";
                textBox7.Enabled = true;
            }
            if (comboBox1.Text == "Pharmacist")
            {
                bunifuCustomLabel9.Text = "Room Number:";
                bunifuCustomLabel8.Text = "";
                textBox7.Enabled = false;
            }
            /*if (comboBox1.Text == "Secretary")
            {
                bunifuCustomLabel9.Text = "";
                bunifuCustomLabel8.Text = "";
                textBox8.Enabled = false;
                textBox7.Enabled = false;
            }*/
            if (comboBox1.Text == "Patient")
            {
                bunifuCustomLabel9.Text = "Age:";
                bunifuCustomLabel8.Text = "Phone:";
                textBox7.Enabled = true;
            }
        }

        void refresh()
        {
            listView1.Items.Clear();
            foreach (Patient t in Accounts.AccP)
            {
                var row = new string[] { "Patient", Convert.ToString(t.ID), t.name, t.password, "Phone: " + t.phone };
                var x = new ListViewItem(row);
                listView1.Items.Add(x);
            }
            foreach (Doctor t in Accounts.AccD)
            {
                var row = new string[] { "Doctor", Convert.ToString(t.ID), t.name, t.password, "Majo: " + t.major + " , Room Number: " + t.roomNumber };
                var x = new ListViewItem(row);
                listView1.Items.Add(x);
            }
            /*foreach (Secretary t in Accounts.AccS)
            {
                var row = new string[] { "Secretary", Convert.ToString(t.ID), t.name, t.password, "none" };
                var x = new ListViewItem(row);
                listView1.Items.Add(x);
            }*/
            foreach (Pharmacist t in Accounts.AccPh)
            {
                var row = new string[] { "Pharmacist", Convert.ToString(t.ID), t.name, t.password, "Room Number: " + t.roomNumber };
                var x = new ListViewItem(row);
                listView1.Items.Add(x);
            }
        }
    }
}
