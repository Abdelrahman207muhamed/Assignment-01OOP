using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01OOP
{
    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private double salary;
        private DateTime hireDate;
        private Gender gender;


        public Employee(int id, string name, SecurityLevel securityLevel, double salary, DateTime hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public int ID
        {
            set
            {
                id = value; 
            }
            get 
            {
                return id;
            }   
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get 
            {
                return name;
            }         
        }

        public SecurityLevel SecurityLevel
        {
            set 
            {
                securityLevel = value;
            }
            get 
            {
                return securityLevel;
            }  
        }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get 
            {
                return salary;
            }           
        }

        public DateTime HireDate
        {
            set
            {
                hireDate = value;
            }
            get
            {
                return hireDate; 
            }
           
        }

        public Gender Gender
        {
            set 
            {
                gender = value; 
            }
            get 
            {
                return gender; 
            }

        }

        public override string ToString()
        {
            return String.Format(
                "Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4:dd/MM/yyyy}\nGender: {5}",
                id, name, securityLevel, salary, hireDate, gender);
        }

    }
}
