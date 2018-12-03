using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LCFGenerator.Models
{
    public class Loan
    {
        // References to initial balance of the loan, term, rate, ID number
        public double Balance { get; set; }
        public int Term {get; set;}
        public int Rate {get; set;}

        //Entity FW will create id
        public int Id {get; set;}

        public double Payment { get; set; }


        // constructor
        public Loan(int balance, int term, int rate)
        {
            this.Balance = balance;
            this.Term = term;
            this.Rate = rate;
            this.Id = 0;
            this.Payment = (this.Balance * (this.Rate / 1200)) / (1 - (Math.Pow((1 + (this.Rate / 1200)), -this.Term * 12)));
        }
    }
}