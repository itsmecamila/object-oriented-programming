using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseBank
{
    public class Bank
    {
        private List<SavingAccount> savingsAccounts;

        //nome de métodos com maíuscula???
        public List<SavingAccount> AccessSavings{
            get{return savingsAccounts;}
            set{savingsAccounts = value;}
        }

        private List<CheckingAccount> checkingAccounts;
        public List<CheckingAccount> AccessChecking{
            get{return checkingAccounts;}
            set{checkingAccounts = value;}
        }

    public Bank(){
        savingsAccounts = new List<SavingAccount>();
        checkingAccounts = new List<CheckingAccount>();
    }

    public void OpenCheckingAccount(double balance,double check){
        checkingAccounts.Add(new CheckingAccount(balance,check));
    }

    public void OpenSavingAccount(double balance){
        savingsAccounts.Add(new SavingAccount(balance));
    }

    public void ShowSavingAccounts(){
            int i = 1;
            foreach(SavingAccount sa in savingsAccounts){
                System.Console.WriteLine();
                System.Console.WriteLine("----------------------------------------------------------");
                System.Console.WriteLine("CONTA POUPANÇA "+ i);
                System.Console.WriteLine("Saldo: "+ sa.AccessBalance);
                i++;
        }
        }

        public void ShowCheckingAccounts(){
            int i = 1;
            foreach(CheckingAccount ca in checkingAccounts){
                System.Console.WriteLine();
                System.Console.WriteLine("----------------------------------------------------------");
                System.Console.WriteLine("CONTA CORRENTE "+ i);
                System.Console.WriteLine("Saldo: "+ ca.AccessBalance +"\t"+ "Cheque especial: "+ ca.AccessCheck);
                i++;
        }
        }

        ~Bank(){
            System.Console.WriteLine("Destruindo...");
        }


    }
}