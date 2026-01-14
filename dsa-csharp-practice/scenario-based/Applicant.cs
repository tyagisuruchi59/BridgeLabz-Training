using System;

namespace LoanBuddy
{
    // ================= INTERFACE =================
    public interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }

    // ================= APPLICANT =================
    public class Applicant
    {
        public string Name { get; private set; }
        private int creditScore;
        public double Income { get; private set; }
        public double LoanAmount { get; private set; }

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            Name = name;
            this.creditScore = creditScore;
            Income = income;
            LoanAmount = loanAmount;
        }

        protected internal int GetCreditScore()
        {
            return creditScore;
        }
    }

    // ================= BASE LOAN =================
    public abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected int Term;            // months
        protected double InterestRate; // annual
        private bool approved;

        protected LoanApplication(Applicant applicant, int term, double interestRate)
        {
            this.applicant = applicant;
            Term = term;
            InterestRate = interestRate;
        }

        protected bool BasicEligibilityCheck()
        {
            return applicant.GetCreditScore() >= 650 &&
                   applicant.Income >= applicant.LoanAmount * 0.3;
        }

        protected double CalculateStandardEMI()
        {
            double P = applicant.LoanAmount;
            double R = InterestRate / (12 * 100);
            int N = Term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }

        protected void SetApprovalStatus(bool status)
        {
            approved = status;
        }

        public bool IsApproved()
        {
            return approved;
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEMI();
    }

    // ================= HOME LOAN =================
    public class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant, int term)
            : base(applicant, term, 8.5)
        {
        }

        public override bool ApproveLoan()
        {
            bool eligible =
                BasicEligibilityCheck() &&
                applicant.GetCreditScore() >= 700;

            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI()
        {
            return CalculateStandardEMI();
        }
    }

    // ================= AUTO LOAN =================
    public class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant, int term)
            : base(applicant, term, 10.5)
        {
        }

        public override bool ApproveLoan()
        {
            bool eligible = BasicEligibilityCheck();
            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI()
        {
            return CalculateStandardEMI() + 500; // processing fee
        }
    }

    // ================= PERSONAL LOAN =================
    public class PersonalLoan : LoanApplication
    {
        public PersonalLoan(Applicant applicant)
            : base(applicant, 36, 14.5)
        {
        }

        public PersonalLoan(Applicant applicant, int term)
            : base(applicant, term, 13.5)
        {
        }

        public override bool ApproveLoan()
        {
            bool eligible = applicant.GetCreditScore() >= 600;
            SetApprovalStatus(eligible);
            return eligible;
        }

        public override double CalculateEMI()
        {
            return CalculateStandardEMI();
        }
    }

    // ================= MAIN PROGRAM =================
    class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant(
                "Suru",
                720,
                90000,
                1500000
            );

            LoanApplication loan = new HomeLoan(applicant, 240);

            Console.WriteLine("Applicant Name: " + applicant.Name);

            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved ");
                Console.WriteLine("Monthly EMI: ₹" + loan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("Loan Rejected ");
                Console.WriteLine("Loan Rejected ");
            }
        }
    }
}
