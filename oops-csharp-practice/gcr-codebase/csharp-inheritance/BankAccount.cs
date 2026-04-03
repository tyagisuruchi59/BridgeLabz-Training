class BankAccount
{
    public int AccountNumber;
    public double Balance;
}

class SavingsAccount : BankAccount
{
    public double InterestRate;
}

class CheckingAccount : BankAccount
{
    public int WithdrawalLimit;
}

class FixedDepositAccount : BankAccount
{
    public int LockPeriod;
}
