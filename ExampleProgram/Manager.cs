namespace ExampleProgram
{
   public class Manager : Consultant
    {
        private decimal bonus;
        public Manager(string name, string practice, int salary, decimal bonus) : base(name, practice, salary)
        {
            this.bonus = bonus;
        }

        public override decimal GetPay()
        {
            return _salary + bonus;
        }
    }
}
