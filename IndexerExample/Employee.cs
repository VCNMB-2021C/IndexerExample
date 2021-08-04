using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Employee
    {
        double salary;
        string empNumber, jobTitle, name, surname;

        public Employee(string empNumber, string jobTitle,
            string name, string surname,double salary )
        {
            this.salary = salary;
            this.empNumber = empNumber;
            this.jobTitle = jobTitle;
            this.name = name;
            this.surname = surname;
        }

        public double Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.empNumber;
                else if (index == 1)
                    return this.jobTitle;
                else if (index == 2)
                    return this.name;
                else if (index == 3)
                    return this.surname;
                else if (index == 4)
                    return this.salary;
                return null;
            }
            set
            {
                if (index == 0)
                    this.empNumber=(string)value;
                else if (index == 1)
                    this.jobTitle = (string)value;
                else if (index == 2)
                    this.name = (string)value;
                else if (index == 3)
                    this.surname = (string)value;
                else if (index == 4)
                    this.salary = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("empnumber"))
                    return this.empNumber;
                else if (attrName.ToLower().Equals("jobtitle"))
                    return this.jobTitle;
                else if (attrName.ToLower().Equals("name"))
                    return this.name;
                else if (attrName.ToLower().Equals("surname"))
                    return this.surname;
                else if (attrName.ToLower().Equals("salary"))
                    return this.salary;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("empnumber"))
                        this.empNumber = (string)value;
                else if (attrName.ToLower().Equals("jobtitle"))
                    this.jobTitle = (string)value;
                else if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (attrName.ToLower().Equals("surname"))
                    this.surname = (string)value;
                else if (attrName.ToLower().Equals("salary"))
                    this.salary = (double)value;
            }
        }

    }
}
