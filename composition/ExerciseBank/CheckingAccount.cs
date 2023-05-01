using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseBank
{
    public class CheckingAccount
    {
        private double balance;

        public double AccessBalance{
            get{return balance;}
            set{balance = value;}
        }
        private double specialCheck;

        public double AccessCheck{
            get{return specialCheck;}
            set{specialCheck = value;}
        }
        public CheckingAccount(){ }
        public CheckingAccount(double balance, double specialCheck){
            this.balance = balance;
            this.specialCheck = specialCheck;
        }

        ~CheckingAccount(){
            System.Console.WriteLine("Destruindo...");
        }   
    }
}