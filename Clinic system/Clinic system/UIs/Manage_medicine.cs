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
    public partial class Manage_medicine : UserControl
    {
        public Manage_medicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || Convert.ToInt32(textBox3.Text) < 0)
            {
                MessageBox.Show("Error info!!!");
            }
            else
            {
                try
                {
                    bool itOut = true;
                    int u = Convert.ToInt32(textBox3.Text);
                    foreach (List<string> t in Medecine.mIn)
                    {
                        if (t[0] == textBox1.Text)
                        {
                            t[1] = Convert.ToString(Convert.ToInt32(t[1]) + Convert.ToInt32(textBox3.Text));
                            itOut = false;
                        }
                    }
                    if (itOut)
                    {
                        List<string> m = new List<string> { textBox1.Text, textBox3.Text };
                        Medecine.mIn.Add(m);
                    }
                    refresh();
                }
                catch
                {
                    MessageBox.Show("Error info!!");
                }
                textBox1.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            listView1.Items.Clear();
            foreach (List<string> t in Medecine.mIn)
            {
                var row = new string[] { t[0], t[1]};
                var x = new ListViewItem(row);
                listView1.Items.Add(x);
            }
        }

        private void Manage_medicine_Load(object sender, EventArgs e)
        {

        }
    }
}
