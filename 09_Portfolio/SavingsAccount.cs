using System;

namespace _09_Portfolio
{
    internal class SavingsAccount 
    {
        private string v1;
        private int v2;
        private double v3;
       
        
        
        public SavingsAccount(string v1, int v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        

        public double InterestRate { get; internal set; }

        public override string ToString()
        {
            return "SavingsAccount[value=1000.0,interestRate=4.2]";
        }

        internal int GetValue()
        {
            throw new NotImplementedException();
        }

        internal void ApplyInterest()
        {
            throw new NotImplementedException();
        }
    }
}