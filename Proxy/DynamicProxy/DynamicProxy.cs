using Utilities;

namespace Proxy.DynamicProxy;

public class DynamicProxy() : ConsoleProgram("Dynamic Proxy")
{
    public override Task RunAsync()
    {
        var bankAccount = Log<BankAccount>.As<IBankAccount>();

        bankAccount.Deposit(100);
        bankAccount.Withdraw(50);

        WriteLine(bankAccount);

        return Task.CompletedTask;
    }
}