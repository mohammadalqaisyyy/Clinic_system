using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_system
{
    public partial class Login : Form
    {
        bool drag = false;
        Point start = new Point(0, 0);
        Manager m = Manager.GetManager();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Doctor d = new Doctor(2, "Ahmad", "chest", "m", 2); //(int ID, string name, string major, string password, int roomNumber)
            Patient p = new Patient(4, "baraa", 21, "b4", "078958675");//(int ID, string name, int Age,string password)
            Patient p2 = new Patient(5, "bara'a", 21, "b5", "0789589632");
            Pharmacist ph = new Pharmacist(3, "pharm", "ph", 3);//(int ID,string name,string password, int roomNumber)
            //  Secretary s = new Secretary(4, "s", "s"); //(int id, string name,string password)
            Accounts.AccP.Add(p);
            Accounts.AccD.Add(d);
            Accounts.AccP.Add(p2);
            Accounts.AccPh.Add(ph);
            //Accounts.AccS.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text, pass = textBox2.Text;
            bool x = false;
            if (id == Convert.ToString(m.ID))
            {
                if (pass == m.password)
                {
                    x = true;
                    Form1 f = new Form1(m.ID, "M");
                    f.Show();
                }
            }
                foreach (Patient t in Accounts.AccP)
                {
                    if (id == Convert.ToString(t.ID))
                    {
                        if (pass == t.password)
                        {
                            x = true;
                            Form1 f = new Form1(t.ID, "P");
                            f.Show();
                        }
                    }
                }
                foreach (Doctor t in Accounts.AccD)
                {
                    if (id == Convert.ToString(t.ID))
                    {
                        if (pass == t.password)
                        {
                            x = true;
                            Form1 f = new Form1(t.ID, "D");
                            f.Show();
                        }
                    }
                }
                /*foreach (Secretary t in Accounts.AccS)
                {
                    if (id == Convert.ToString(t.ID))
                    {
                        if (pass == t.password)
                        {
                            Form1 f = new Form1(t.ID, "S");
                            f.Show();
                        }
                    }
                }*/
                foreach (Pharmacist t in Accounts.AccPh)
                {
                    if (id == Convert.ToString(t.ID))
                    {
                        if (pass == t.password)
                        {
                            x = true;
                            Form1 f = new Form1(t.ID, "Ph");
                            f.Show();
                        }
                    }
                }
            if (!x)
            {
                MessageBox.Show("Error info!!");
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }
    }
}
