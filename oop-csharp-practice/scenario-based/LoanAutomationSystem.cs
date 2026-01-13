using System;

namespace LoanAutomation
{
    interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }

    class Applicant
    {
        private string name;
        private int creditScore;
        private double income;
        private double loanAmount;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }

        public int GetCreditScore()
        {
            return creditScore;
        }

        public double GetIncome()
        {
            return income;
        }

        public double GetLoanAmount()
        {
            return loanAmount;
        }

        public string GetName()
        {
            return name;
        }
    }

    abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected int term;
        protected double interestRate;
        private bool approved;

        public LoanApplication(Applicant applicant, int term, double interestRate)
        {
            this.applicant = applicant;
            this.term = term;
            this.interestRate = interestRate;
            this.approved = false;
        }

        protected void SetApproved(bool status)
        {
            approved = status;
        }

        public bool IsApproved()
        {
            return approved;
        }

        protected double CalculateEMIFormula(double principal, double rate, int months)
        {
            double r = rate / (12 * 100);
            double numerator = principal * r * Math.Pow(1 + r, months);
            double denominator = Math.Pow(1 + r, months) - 1;
            return numerator / denominator;
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }

    class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant, int term)
            : base(applicant, term, 8.5)
        {
        }

        public override bool ApproveLoan()
        {
            if (applicant.GetCreditScore() >= 700 &&
                applicant.GetIncome() >= 50000)
            {
                SetApproved(true);
                return true;
            }
            return false;
        }

        public override double CalculateEMI()
        {
            return CalculateEMIFormula(
                applicant.GetLoanAmount(),
                interestRate,
                term
            );
        }
    }

    class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant, int term)
            : base(applicant, term, 9.5)
        {
        }

        public override bool ApproveLoan()
        {
            if (applicant.GetCreditScore() >= 650 &&
                applicant.GetIncome() >= 30000)
            {
                SetApproved(true);
                return true;
            }
            return false;
        }

        public override double CalculateEMI()
        {
            return CalculateEMIFormula(
                applicant.GetLoanAmount(),
                interestRate,
                term
            );
        }
    }

    class PersonalLoan : LoanApplication
    {
        public PersonalLoan(Applicant applicant, int term)
            : base(applicant, term, 12.0)
        {
        }

        public override bool ApproveLoan()
        {
            if (applicant.GetCreditScore() >= 600 &&
                applicant.GetIncome() >= 25000)
            {
                SetApproved(true);
                return true;
            }
            return false;
        }

        public override double CalculateEMI()
        {
            return CalculateEMIFormula(
                applicant.GetLoanAmount(),
                interestRate,
                term
            );
        }
    }

    class LoanAutomationSystem
    {
        static void Main()
        {
            Applicant applicant = new Applicant(
                "Vijay",
                720,
                60000,
                500000
            );

            LoanApplication loan = new HomeLoan(applicant, 240);

            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved");
                Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }
        }
    }
}
