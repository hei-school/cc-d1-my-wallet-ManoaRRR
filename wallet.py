class Wallet:
    def __init__(self, balance=0):
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount

    def withdraw(self, amount):
        if amount > self.balance:
            raise ValueError("Insufficient funds")
        self.balance -= amount

    def get_balance(self):
        return self.balance


# Exemple d'utilisation
wallet = Wallet(100)
wallet.deposit(50)
print(wallet.get_balance())  # 150
wallet.withdraw(25)
print(wallet.get_balance())  # 125
