using ExerciseBank;

Bank b1 = new Bank();
bool play = true;

while(play == true){
    System.Console.WriteLine("CRIAÇÃO DE CONTA CORRENTE");
    System.Console.WriteLine();
    System.Console.Write("Digite o saldo da conta corrente: ");
    double balanceForChecking = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Digite o cheque especial: ");
    double check = Convert.ToDouble(Console.ReadLine());
    b1.OpenCheckingAccount(balanceForChecking,check);

    System.Console.WriteLine();
    System.Console.WriteLine("CRIAÇÃO DE CONTA POUPANÇA");
    System.Console.WriteLine();
    System.Console.Write("Digite o saldo da conta poupança: ");
    double balanceForSaving = Convert.ToDouble(Console.ReadLine());
    b1.OpenSavingAccount(balanceForSaving);

    System.Console.WriteLine();
    System.Console.Write("Deseja cadastrar mais contas? 1 para sim / 2 para não: ");
    int op = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();

    if(op == 1){
        play = true;
    }

    else{
        play = false;
    }
}

b1.ShowSavingAccounts();
b1.ShowCheckingAccounts();

b1 = null;
GC.Collect();

