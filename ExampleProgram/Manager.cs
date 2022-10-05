namespace ExampleProgram
{
   public class Manager : Consultant
    {
        private decimal _bonus;
        public Manager(string name, string practice, int salary, decimal bonus) : base(name, practice, salary)
        {
            _bonus = bonus;
        }

        public override decimal GetPay()
        {
            return _salary + _bonus;
        }
    }
}
