public class Wallet {
    private int balance;

    public Wallet(int balance) {
        this.balance = balance;
    }

    public void deposit(int amount) {
        this.balance += amount;
    }

    public void withdraw(int amount) {
        if (amount > this.balance) {
            throw new RuntimeException("Insufficient funds");
        }
        this.balance -= amount;
    }

    public int getBalance() {
        return this.balance;
    }
}

// Exemple d'utilisation
Wallet wallet = new Wallet(100);
wallet.deposit(50);
System.out.println(wallet.getBalance()); // 150
wallet.withdraw(25);
System.out.println(wallet.getBalance()); // 125
