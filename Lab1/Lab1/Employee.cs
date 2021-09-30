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

        /* Am ales abstract deoarece ne-am dorit ca metoda Salutation sa fie implementată obligatoriu de fiecare clasă Manager si Arhitect.
         * N-ar trebui sa existe un Employee fara o functie bine definita.
         * Daca am fi ales virtual puteam sa implementam un comportament implicit metodei, ex: return "Hello employee", 
         * dar în cele două clase derivate din Employee nu mai era nevoie sa fie implementată.
         */
        public abstract String Salutation();
    }
}
