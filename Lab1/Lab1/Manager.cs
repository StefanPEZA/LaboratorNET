namespace Lab1
{
    public class Manager : Employee
    {
        public override string Salutation()
        {
            return "Hello manager " + GetFullName();
        }
    }
}
