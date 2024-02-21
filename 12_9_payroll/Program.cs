
using System;



namespace _10201_12_9E

{


    public class Date

        {


    //variables for holding the b_month and the date

    private int b_month;

            private int b_day;

       

    //property for auto-created variable Year

    public int Year

            {

                get;

                private set;

            }


    /* Constructor to set the date

    * @param t_Month is the b_month of birth

    * @param t_Day is the b_day of birth

    * @param t_Year is the year of birth

    */

    public Date(int t_Month, int t_Day, int t_Year)

            {


                Month = t_Month;

                Year = t_Year;

                Day = t_Day;
            }


    // property to set and fetch the b_month

    public int Month
            {
                get
                {

                    return b_month;

                }

                private set

                {


    //check if the b_month is valid value

    if (value > 0 && value <= 12)

                            b_month = value;


    else

                        throw new ArgumentOutOfRangeException(

                        "Month", value, "Month must be 1-12");
                }
            }


    //property to fetch and set the b_day

    public int Day
            {
                get
                {

                    return b_day;

                }

                private set

                {


    //array of date values

    int[] daysPerMonth = { 0, 31, 28, 31, 30,

    31, 30, 31, 31, 30, 31, 30, 31 };


    // check if the b_day is valid for the

                        // selected b_month

    if (value > 0 && value <=

    daysPerMonth[Month])

                            b_day = value;

                        // check if the year is a leap year

                        else if (Month == 2 && value == 29 && (Year

                        % 400 == 0 && (Year % 4 == 0 && Year % 100

                        != 0)))

                            b_day = value;

                        else
                        

                            throw new ArgumentOutOfRangeException

                            ("Day", value, "Day out of range for current month / year");
            
    }

            }


    /* Method to return the string form of the date

    */

    public override string ToString()

            {

                return string.Format("{0}/{1}/{2}", Month, Day, Year);
            }
        }


    //define the abstract class employee

    public abstract class Employee

        {


    //create an object of Date class

    private Date birthDate;


    //property to fetch and set employee's first name

    public string F_Name
            {
                get;
                private set;

            }


    //property to fetch and set the last name of the

            //employee

    public string L_Name
            {
                get;

                private set;

            }


    //property to fetch and set employee's SSN

    public string Soc_Sec_Number

            {

                get;

                private set;

            }


    /* Constructor to set the details of employee

    * object

    * @param fName is the fName name

    * @param lName is the lName name

    * @param e_ssn is the employee's social security

    * number

    * @param b_month is the b_month of birth for the

    * employee

    * @param date is the birth date for the employee

    * @param year is the year of birth for the

    * employee

    */

    public Employee(string fName, string lName, string

    e_ssn, int month, int date, int year)

            {


                F_Name = fName;

                L_Name = lName;

                Soc_Sec_Number = e_ssn;
                birthDate = new Date(month, date, year);
            }


    /* Method to get the month of birth for the

    * employee

    * @return the month of birth

    */

    public int BirthMonth()

            {

                return birthDate.Month;

            }


    /* Method to get the information of the employee is

    * the string form

    */

    public override string ToString()

            {

                return string.Format("{ 0} { 1}\nsocial security number: { 2}", F_Name, L_Name, Soc_Sec_Number);

    }


    //method Tot_Income is overridden over here

            //implementation is not provided

    public abstract decimal Tot_Income();

        }


    //Derived class for employees who are salaried

    public class SalariedEmployee : Employee
        {

    //variable to hold the week Salary

    private decimal w_Salary;


    /* Constructor to set the details of the employee

    * @param fName is the fName name

    * @param lName is the lName name

    * @param e_ssn is the social security number of

    * the employee

    * @param b_month is the b_month of birth for the

    * employee

    * @param date is the date of birth for the

    * employee

    * @param year is employee's year of birth

    * @param eSal is employee's eSal of a week

    */

    public SalariedEmployee(string fName, string lName,

    string e_ssn, decimal eSal, int month, int date,

    int year)

    : base(fName, lName, e_ssn, month, date, year)

            {

                WeekSalary = eSal;

            }


    //property to fetch and set the employee's eSal

    public decimal WeekSalary
            {
                get
                {

                    return w_Salary;

                }

                set

                {


    //check if the eSal is valid

    if (value >= 0)

                        w_Salary = value;

                    else

                        throw new ArgumentOutOfRangeException

                        ("WeeklySalary", value, "WeeklySalary must be >= 0");
            
    }

            }


    /* Method to calculate the income of the employee

    * @return the total income of the employee

    */

    public override decimal Tot_Income()

            {

                return WeekSalary;

            }


    /* Method to get the information of the employee in

    * the string form

    * @return the details of the employee

    */

    public override string ToString()

            {

                return string.Format("salaried employee:{ 0}\n{ 1}: { 2:C}:", base.ToString(), "weekly salary", WeekSalary);

    }

        }


    //derived class for employees who are paid on hourly

    //basis

    public class HourlyEmployee : Employee

        {


    //per hour e_wage

    private decimal e_wage;

            //number of wHours the employee worked for

            private decimal wHours;


    /* Constructor to set the details of the employee

    * @param fName is the fName name

    * @param lName is the lName name

    * @param e_ssn is the social security number of

    * the employee

    * @param b_month is the b_month of birth for the

    * employee

    * @param date is the employee's date of birth

    * @param year is the employee's year of birth

    * @param hourlyWage is the waage per hour of the

    * employee

    * @param hoursWorked is the number of total hours

    * the employee worked for in the week

    */

    public HourlyEmployee(string fName, string lName,

    string e_ssn,

    decimal hourlyWage, decimal hoursWorked, int month,

    int date, int year)

    : base(fName, lName, e_ssn, month, date, year)

            {


    //set the details

    E_Wage = hourlyWage;

                WHours = hoursWorked;
            }

    // property to fetch and set the e_wage

    public decimal E_Wage
            {
                get
                {

                    return e_wage;

                }

                set

                {


    //check if the eSal is a valid value

    if (value >= 0)

                        e_wage = value;

                    else

                        throw new ArgumentOutOfRangeException

                        ("Wage", value, "Wage must be>= 0");

                }

            }


    // property to fetch and set hourly employee's

            // hours

    public decimal WHours
            {
                get
                {
                    return wHours;
                }
                set
                {


    //check if the wHours value is valid

    if (value >= 0 && value <= 168)

                        wHours = value;

                    else throw new ArgumentOutOfRangeException

                    ("Hours", value, "Hours must be>=0 and<=168");
            
    }

            }


    /* Overridden method to get the total income of the

    * employee

    * @return the total earnings of the employee

    */

    public override decimal Tot_Income()
            {


    if (WHours <= 40)

                        return E_Wage * WHours;

                    else

                        return (40 * E_Wage) + ((WHours - 40) *

                        E_Wage * 1.5M);

            }


    /* Overridden method to get the string form of the

    * employee's details

    * @return the string form of employee's details

    */

    public override string ToString()

            {

                return string.Format("hourly employee: { 0}\n{ 1}.:.{ 2:C}", base.ToString(),"hourly wage", e_wage, "working hours", WHours);

            }

        }


    //class to test the application

    class EmployeeBonusTest

        {


    //define Main()

    static void Main(string[] args)

            {


                //create the salaried employees

                SalariedEmployee se1 = new SalariedEmployee

                ("James", "Reacher", "124-11-1232", 1000.0m, 5,

                11, 1997);

        SalariedEmployee se2 = new SalariedEmployee

        ("Jack", "Perry", "126-12-1244", 1000.0m, 7,

        21, 1994);


        //create the hourly employees

        HourlyEmployee he1 = new HourlyEmployee

        ("Phile", "Jackson", "152-243-1322", 50.0m,

        28.0m, 9, 13, 1987);

        HourlyEmployee he2 = new HourlyEmployee("Brad",

        "Pitt", "152-243-1422", 43.0m, 24.0m, 11, 12,

        1987);


        //create an array of Employee type to hold the

        //employees

        Employee[] empArr = { se1, se2, he1, he2 };


    //get current b_month

    int thisMonth = DateTime.Now.Month;

        //declare a variable to hold the eSal

        decimal mySal;


    //go through the entire employee objects

    foreach (Employee e in empArr)

    {


    //get the b_month of birth of employee

    int myBMonth = e.BirthMonth();


    //check if the employee is salaried

    //employee

    if (e is SalariedEmployee)

    {

            //type cast the employee in salaried

            //employee

            SalariedEmployee se =

            (SalariedEmployee)e;


    //check if the ongoing month is the

            //birth month of the employee

    if (myBMonth == thisMonth)


                //add the bonus amount to the

                //earnings

                mySal = se.Tot_Income() + 100.0m;

            //print the details of earnings

            Console.WriteLine("{0} has gained:{ 1:C}\n", se, se.Tot_Income());

    }


    //check if the employee is an hourly

    //employee

    else if (e is HourlyEmployee)

    {


    //type cast the employee into hourly

    //employee

    HourlyEmployee he = (HourlyEmployee)e;

    
    //check if the ongoing month is the

    //employee's birth month

    if (myBMonth == thisMonth)

        {


            //add the bonus amount to the eSal

            mySal = he.Tot_Income() + 100.0m;

            Console.WriteLine("\n{0} has got a bonus of $100.00: ", he.F_Name);
    
    }

        //print th details of earnings

        Console.WriteLine("{0} has gained:{1:C}\n", he, he.Tot_Income());

    }

    }

    Console.ReadKey();

    }

    }

}