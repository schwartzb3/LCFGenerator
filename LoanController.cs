using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LCFGenerator.Models;


namespace LCFGenerator.Controllers
{
    public class LoanController : ApiController
    {
        // Want to have a array of loans with loan ID (set by us), this would query our database or another data source
        Loan[] loans = new Loan[]
        {
            new Loan(250000,30,15),
            new Loan(100000,10,3)
        };

        // Way to get array of all of our loans
        public IEnumerable<Loan> GetAllLoans()
        {
            return loans;
        }

        // Get a certain loan by ID (?)

        public IHttpActionResult GetLoan(int id)
        {
            var loan = loans.FirstOrDefault((p) => p.Id == id);
            if (loan == null)
            {
                return NotFound();
            }
            return Ok(loan);
        }
        // Method to create a new loan from our inputs in the site

        public Loan CreateLoan(int balance, int term, int rate)
        {
            Loan temp = new Loan(balance, term, rate);
            return temp;
        }

        public Array GetPaymentSchedule(Loan loan)
        {
            double[] schedule = new double[loan.Term * 12];
            for (int i = 0; i < schedule.Length; i++)
            {
                schedule[i] = loan.Payment;
            }
            return schedule;
        }

        public Array GetRemainingBalance(Loan loan)
        {
            double[] remBal = new double[loan.Term * 12];
            for (int i = 0; i < remBal.Length; i++)
            {
                remBal[i] = loan.Balance - (i + 1) * loan.Payment;
            }

            return remBal;
        }

        public Array GetInterestPayments(Loan loan)
        {
            double[] intPayments = new double[loan.Term * 12];
            for (int i = 0; i < intPayments.Length;i++)
            {
                intPayments[i] = (loan.Balance - (i + 1) * loan.Payment) * loan.Rate / 1200;
            }
            return intPayments;
        }
    }
}
