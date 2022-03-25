using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_system
{
    public static class Accounts
    {
        public static int IDs = 6;
        public static List<Patient> AccP = new List<Patient>(); // id, name, age, password, phone 
        public static List<Doctor> AccD = new List<Doctor>(); // ID, name, major, password, roomNumber
        //public static List<Secretary> AccS = new List<Secretary>(); // id, name, password
        public static List<Pharmacist> AccPh = new List<Pharmacist>(); // id, name, password, roomNumber
    }

    sealed class Manager
    {
        int ID_, roomNumber_;
        string name_, password_;

        Manager(int id, string name, string password, int roomNumber)
        {
            ID_ = id;
            name_ = name;
            password_ = password;
            roomNumber_ = roomNumber;
        }

        public int ID {
            get { return ID_; }
        }
        public int RoomNumber
        {
            get { return roomNumber_; }
        }
        public string Name
        {
            get { return name_; }
        }
        public string password
        {
            get { return password_; }
        }

        static Manager manager_ = new Manager(1, "Mhmd", "m", 1);

        public static Manager GetManager()
        {
            return manager_;
        }

        public void addPatient(string name, int Age, string password, string phone)
        {
            Patient p = new Patient(Accounts.IDs, name, Age, password, phone);
            Accounts.AccP.Add(p);
            Accounts.IDs += 1;
        }

        public void addDoctor(string name, string major, string password, int roomNumber)
        {
            Doctor d = new Doctor(Accounts.IDs, name, major, password, roomNumber);
            Accounts.AccD.Add(d);
            Accounts.IDs += 1;
        }
        public void addPharmacist(string name, string password, int roomNumber)
        {
            Pharmacist p = new Pharmacist(Accounts.IDs, name, password, roomNumber);
            Accounts.AccPh.Add(p);
            Accounts.IDs += 1;
        }

    }
}
