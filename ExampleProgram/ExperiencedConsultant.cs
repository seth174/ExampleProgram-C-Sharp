namespace ExampleProgram
{
   public class ExperiencedConsultant : Consultant
    {
        private decimal _bonus;
        public ExperiencedConsultant(string name, string practice, int salary, decimal bonus) : base(name, practice, salary)
        {
            _bonus = bonus;
        }

        public override decimal GetPay()
        {
            return Salary + _bonus;
        }
    }
}
