// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");

BankAccount acc1 = new BankAccount("Acc1", "Name1");
Currency c1 = new Currency("GEL", 12.23M);
Currency c2 = new Currency("GEL", 18.22M);
Currency c3 = new Currency("GEL", 8.22M);
Currency c4 = new Currency("GEL", 22.23M);

BankAccount acc2 = new BankAccount("Acc2", "Name2");

Console.WriteLine(acc1.BalanceCheck());

acc1.Deposit(c1);
Console.WriteLine(acc1.BalanceCheck());

acc1.Deposit(c2);
Console.WriteLine(acc1.BalanceCheck());

acc1.Withdraw(c3);
Console.WriteLine(acc1.BalanceCheck());

Console.WriteLine(acc2.BalanceCheck());
acc1.TransferFunds(acc2, new Currency("GEL", 15.45M));
Console.WriteLine(acc1.BalanceCheck());

Console.WriteLine(acc2.BalanceCheck());

/*

acc1.Withdraw(c4);
Console.WriteLine(acc1.BalanceCheck());

acc1.Withdraw(new Currency("Gel", 0.001M));
Console.WriteLine(acc1.BalanceCheck());*/
