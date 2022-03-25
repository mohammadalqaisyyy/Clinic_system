using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_system
{
    public static class reports
    {
        public static List<List<string>> Reports = new List<List<string>>(); // ID, report, medicine, quantity
        public static void addReport(int id, string report, string medecine, int quantity)
        {
            foreach (List<string> t in Reports)
            {
                if (Convert.ToInt32(t[0]) == id)
                {
                    t[1] = report;
                    t[2] = medecine;
                    t[3] = Convert.ToString(quantity);
                    return;
                }
            }
            //List<string> s = new List<string> { Convert.ToString(id), report, medecine, Convert.ToString(quantity) };
        }
    }

    public class Patient
    {
        public int ID, Age;
        public string name, password, phone;
        public string appointments = "no";
        public static List<List<string>> Reports = new List<List<string>>(); // ID, report, medicine, quantity

        public Patient(int ID, string name, int Age, string password, string phone)
        {
            this.ID = ID;
            this.name = name;
            this.Age = Age;
            this.password = password;
            this.phone = phone;
            List<string> r = new List<string> { Convert.ToString(ID), "Good", "No", "0" };
            reports.Reports.Add(r);
        }

        void editPatient(string name, int Age, string password, string phone)
        {
            this.name = name;
            this.Age = Age;
            this.password = password;
            this.phone = phone;
        }
    }
}
