namespace ExampleProgram
{
    public class Consultant
    {
        public string Name { get; set; }
        public string Practice { get; set; }
        protected decimal _salary;

        public Consultant(string name, string practice, decimal salary)
        {
            Name = name;
            Practice = practice;
            _salary = salary;
        }

        public virtual decimal GetPay()
        {
            return _salary;
        }

        public override string ToString()
        {
            return $"{Name} is in the {Practice} practice with a compensation of {GetPay()}";
        }
    }
}
