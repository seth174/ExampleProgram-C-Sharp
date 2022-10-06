namespace ExampleProgram
{
    public class Consultant
    {
        public string Name { get; set; }
        public string Practice { get; set; }
        protected decimal Salary { get; set; }

        public Consultant(string name, string practice, decimal salary)
        {
            Name = name;
            Practice = practice;
            Salary = salary;
        }

        public virtual decimal GetPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{Name} is in the {Practice} practice with a compensation of {GetPay()}";
        }
    }
}
