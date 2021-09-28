namespace Lab1
{
    public class Architect : Employee
    {
        public override string Salutation()
        {
            return "Hello architect " + GetFullName();
        }
    }
}
