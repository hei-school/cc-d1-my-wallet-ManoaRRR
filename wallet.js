class Wallet {
    constructor(balance = 0) {
        this.balance = balance;
    }

    deposit(amount) {
        this.balance += amount;
    }

    withdraw(amount) {
        if (amount > this.balance) {
            throw new Error("Insufficient funds");
        }
        this.balance -= amount;
    }

    get balance() {
        return this.balance;
    }
}

// Exemple d'utilisation
const wallet = new Wallet(100);
wallet.deposit(50);
console.log(wallet.balance); // 150
wallet.withdraw(25);
console.log(wallet.balance); // 125
