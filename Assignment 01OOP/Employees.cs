using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01OOP
{
    internal class Employees
    {


        private char gender;


        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    new ArgumentException("Gender must be 'M' or 'F'.");
            }
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public double Salary { get; set; }
        public Hiring_Date HireDate { get; set; }



        public Employees(int id, string name, SecurityLevel security, double salary, Hiring_Date hireDate, char gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
                                  ID, Name, Security, Salary, HireDate, Gender);
        }






    }
}
