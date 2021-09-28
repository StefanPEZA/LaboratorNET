using System;

namespace Lab1
{
    public abstract class Employee
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }

        public String GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public Boolean IsActive()
        {
            return (EndDate - StartDate) > TimeSpan.Zero;
        }

        /* Am folosit abstract deoarece metoda Salutation ar trebui implementata
         * de fiecare subclasa (Manager, Architect). 
         */
        public abstract String Salutation();
    }
}
