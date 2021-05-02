namespace HerancaPolimorfismo_Ex1.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, 
                                 int hours, 
                                 double valuraPerHour, 
                                 double additionalCharge) 
            : base(name, hours, valuraPerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
