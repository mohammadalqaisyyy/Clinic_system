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
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start = new Point(0, 0);

        string type_;
        int id_;
        UIs.Dashboard_Manager m;
        UIs.Dashboard_P p;
        UIs.Dashboard_Doctor d;
        UIs.Dashboard_Pharmacist ph;
        UIs.Dashboad_Secretary s;
        public Form1(int id,string type)
        {
            InitializeComponent();
            type_ = type;
            id_ = id;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1100;
            this.Height = 550;
            if (type_ == "M")
            {
                m = new UIs.Dashboard_Manager();
                panel2.Controls.Clear();
                panel2.Controls.Add(m);
                button2.Text = "Accounts";
                button3.Enabled = false;
                button3.Text = "";
                button4.Enabled = false;
                button4.Text = "";
            }
            if (type_ == "P")
            {
                p = new UIs.Dashboard_P(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(p);
                button4.Enabled = false;
                button2.Text = "Report";
                button3.Text = "Edit";
                button4.Text = "";
            }
            if (type_ == "D")
            {
                panel2.Controls.Clear();
                d = new UIs.Dashboard_Doctor(id_);
                panel2.Controls.Add(d);
                button2.Text = "Add Report";
                button4.Enabled = false;
                button4.Text = "";
            }
            if (type_ == "Ph")
            {
                panel2.Controls.Clear();
                ph = new UIs.Dashboard_Pharmacist(id_);
                panel2.Controls.Add(ph);
                button2.Text = "Medecine";
                button4.Enabled = false;
                button4.Text = "";
            }
            if (type_ == "S")
            {
                panel2.Controls.Clear();
                s = new UIs.Dashboad_Secretary(id_);
                panel2.Controls.Add(s);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type_ == "P")
            {
                p = new UIs.Dashboard_P(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(p);
            }
            if (type_ == "D")
            {
                d = new UIs.Dashboard_Doctor(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(d);
            }
            if (type_ == "Ph")
            {
                ph = new UIs.Dashboard_Pharmacist(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(ph);
            }
            if (type_ == "M")
            {
                m = new UIs.Dashboard_Manager();
                panel2.Controls.Clear();
                panel2.Controls.Add(m);
            }
            if (type_ == "S")
            {
                m = new UIs.Dashboard_Manager();
                panel2.Controls.Clear();
                panel2.Controls.Add(m);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (type_ == "P")
            {
                UIs.Edit_Patient eP = new UIs.Edit_Patient(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(eP);
            }
            if (type_ == "D" || type_ == "Ph")
            {
                UIs.view_report eP = new UIs.view_report(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(eP);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (type_ == "D")
            {
                UIs.report_doctor eP = new UIs.report_doctor(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(eP);
            }
            if (type_ == "Ph")
            {
                UIs.Manage_medicine mM = new UIs.Manage_medicine();
                panel2.Controls.Clear();
                panel2.Controls.Add(mM);
            }
            if (type_ == "M")
            {
                UIs.Edit_manager eM = new UIs.Edit_manager();
                panel2.Controls.Clear();
                panel2.Controls.Add(eM);
            }
            if (type_ == "P")
            {
                UIs.view_report rP = new UIs.view_report(id_);
                panel2.Controls.Clear();
                panel2.Controls.Add(rP);
                button2.Text = "Report";
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
