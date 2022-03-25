using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_system
{
    public static class Medecine
    {
        public static List<List<string>> mIn = new List<List<string>>(); // name, q
        public static List<List<string>> mOut = new List<List<string>>(); // ID ,name ,q
    }
    public class Pharmacist
    {
        public int ID, roomNumber;
        public string name, password;
        public int maxQuantity = 30;

        public Pharmacist(int ID,string name,string password, int roomNumber)
        {
            this.ID = ID;
            this.name = name;
            this.password = password;
            this.roomNumber = roomNumber;
        }

        public void addMedecine(string s1,string s2)
        {
            foreach(List<string> t in Medecine.mIn)
            {
                if (t[0]==s1)
                {
                    try
                    {
                        t[2] += Convert.ToInt32(s2);
                    }
                    catch
                    {
                        MessageBox.Show("Error!!");
                    }
                    return;
                }
            }
            List<string> s = new List<string> { s1, s2 };
            Medecine.mIn.Add(s);
        }

        public int percentMedecine()
        {
            float sum = 0, sub = 0;
            foreach (List<string> t in Medecine.mIn)
            {   
                sub += (30 - Convert.ToInt32(t[1]));
                sum += 30;
            }
            if (sum == 0)
                return 0;
            else
                return Convert.ToInt32(((sum-sub)/sum)*100);
        }


        public void subMedecine(int ID)
        {
            foreach(List<string> t in Medecine.mOut)
            {
                if (t[0] == Convert.ToString(ID))
                {
                    foreach(List<string> u in Medecine.mIn)
                    {
                        if (t[1] == u[0])
                        {
                            if(Convert.ToInt32(t[2]) <= Convert.ToInt32(u[1]))
                            {
                                t[2] = Convert.ToString(Convert.ToInt32(u[1]) - Convert.ToInt32(t[2]));
                                return;
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Error!!");
        }
    }

}
