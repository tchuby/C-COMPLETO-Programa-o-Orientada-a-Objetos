namespace HerancaPolimorfismo_ExProp2.Entities
{
    class Individual : TaxPayer
    {
        public double HealfExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healfExpenditures) :
            base (name, anualIncome)
        {
            HealfExpenditures = healfExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000)
                return (AnualIncome * 0.15) - (HealfExpenditures * 0.5);
            else
                return (AnualIncome * 0.25) - (HealfExpenditures * 0.5);
        }
    }
}
