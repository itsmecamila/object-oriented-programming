using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_bank
{
    public class Bank
    {
        private List<SavingAccount> savingsAccounts;

        //nome de métodos com maíuscula???
        public List<SavingsAccount> AccessSavings{
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
    }
}