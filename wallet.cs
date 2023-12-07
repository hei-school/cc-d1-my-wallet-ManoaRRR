public class Wallet
{
    private int balance;

    public Wallet(int balance = 0)
    {
        this.balance = balance;
    }

    public void Deposit(int amount)
    {
        this.balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount > this.balance)
        {
            throw new InsufficientFundsException();
        }
        this.balance -= amount;
    }

    public int GetBalance()
    {
        return this.balance;
    }
}

// Exemple d'utilisation
Wallet wallet = new Wallet(100);
wallet.Deposit(50);
Console.WriteLine(wallet.GetBalance()); // 150
wallet.Withdraw(25);
Console.WriteLine(wallet.GetBalance()); // 125
