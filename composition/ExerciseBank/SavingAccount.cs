using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseBank
{
    public class SavingAccount
        {
        private double balance;

        public double AccessBalance{
            get{return balance;}
            set{balance = value;}
        }

        public SavingAccount(){ }

        public SavingAccount(double balance){
            this.balance = balance;
        }

        ~SavingAccount(){
            System.Console.WriteLine("Destruindo...");
        }
        
    }
    }
