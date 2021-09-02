using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Bank
    {
        //hiding class data by declaring the variable as private
        private double balance;
        //creating public setter and getter methods
        public double getBalance()
        {
            //add validation logic if needed
            return balance;
        }
        public void setBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }
    }
    class Ecapsulation
    {
        public static void Main()
        {
            Bank Boi = new Bank();
            Boi.setBalance(500);
            Console.WriteLine(Boi.getBalance());
            
            Console.ReadLine();
        }
    }
}
