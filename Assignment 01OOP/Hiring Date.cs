using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01OOP
{
    internal class Hiring_Date
    {
        private int day;
        private int month;
        private int year;



        public Hiring_Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
           
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                     new ArgumentException("Day must be between 1 and 31.");
            }
            get
            { 
                return day;
            }
        }


        public int Month
        {
           
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                     new ArgumentException("Month must be between 1 and 12.");
            }
            get
            {
                return month;
            }
        }


        public int Year
        {
           
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    year = value;
                else
                    throw new ArgumentException("Year must be between 1900 and current year.");
            }
            get
            {
                return year; 
            }
        }

       

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

    }
}
