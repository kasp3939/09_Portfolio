﻿using System;

namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        public string Account { get; set; }
        public double InterestRate { get; set; }
        public double Value { get; set; }


        public SavingsAccount() { }

        public SavingsAccount(string account, double value, double interestrate)
        {
            Account = account;
            InterestRate = interestrate;
            Value = value;
        }


        public override string ToString()
        {
            return string.Format("SavingsAccount[value={0:0.0},interestRate={1:0.0}]", Value, InterestRate);
        }

        public double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value += Value * (InterestRate / 100);
        }


    }
}
