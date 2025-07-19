namespace Assignment_01OOP
{
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    enum Gender
    {
        M,
        F
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            //Console.Write("Enter X for Point 1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Y for Point 1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter X for Point 2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Y for Point 2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());


            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));


            //Console.WriteLine($"The distance between the two points is: {distance}");

            //#endregion 
            #endregion

            #region Q2

            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Enter name of person {i + 1}: ");
            //    string name = Console.ReadLine();

            //    Console.Write($"Enter age of person {i + 1}: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    people[i] = new Person(name, age);

            //}

            //Person oldest = people [0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}


            //Console.WriteLine($"The oldest person is: {oldest.Name}, Age: {oldest.Age}");

            //#endregion

            #endregion

            #region Q3

            //Console.Write("Enter Employee ID: ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Employee Name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Select Security Level (0 = Guest, 1 = Developer, 2 = Secretary, 3 = DBA): ");
            //int secLevelChoice = Convert.ToInt32(Console.ReadLine());
            //SecurityLevel secLevel = (SecurityLevel)secLevelChoice;

            //Console.Write("Enter Salary: ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Hire Date (yyyy-mm-dd): ");
            //DateTime hireDate = DateTime.Parse(Console.ReadLine());

            //Console.Write("Enter Gender (M/F): ");
            //char gender = Convert.ToChar(Console.ReadLine().ToUpper());

            //Employee emp = new Employee(id, name, secLevel, salary, hireDate, gender);

            //Console.WriteLine("\nEmployee Details:");
            //Console.WriteLine(emp);

            #endregion

            #region Q4

            //Console.Write("Enter hiring day (1-31): ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter hiring month (1-12): ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter hiring year (e.g. 2023): ");
            //int year = Convert.ToInt32(Console.ReadLine());



            //Hiring_Date hireDate = new Hiring_Date(day, month, year);

            //Console.WriteLine("\nHiring Date is: " + hireDate);


            #endregion

            #region Q5

           // Employee[] EmpArr = new Employee[3];


           // EmpArr[0] = new Employee(
           //     id: 1,
           //     name: "Ali",
           //     securityLevel: SecurityLevel.DBA,
           //     salary: 20000,
           //     hireDate: new Hiring_Date(1, 1, 2020),
           //     gender: 'M'
           // );

           // EmpArr[1] = new Employee(
           //    id: 2,
           //    name: "Sara",
           //    securityLevel: SecurityLevel.Guest,
           //    salary: 5000,
           //    hireDate: new Hiring_Date(15, 5, 2022),
           //    gender: 'F'
           //);

           // EmpArr[2] = new Employee(
           //     id: 3,
           //     name: "Mohamed",
           //     securityLevel: SecurityLevel.SecurityOfficer,
           //     salary: 25000,
           //     hireDate: new Hiring_Date(10, 10, 2018),
           //     gender: 'M'
           // );

           // Console.WriteLine("=== Employee List ===\n");
           // foreach (var emp in EmpArr)
           // {
           //     Console.WriteLine(emp);





                #endregion



            }
        }
}
