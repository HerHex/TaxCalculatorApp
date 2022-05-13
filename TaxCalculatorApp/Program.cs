using System;

namespace TaxCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary amount for taxation ...");
            string GrossSalary = Console.ReadLine();
            int NetSalary = 0;
            int tax = 0;
            int SocialContribution = 0;
            int excess = 0;

            if (int.Parse(GrossSalary) < 1000)
            {
                Console.WriteLine($"The net Salary amount is {GrossSalary}");
            } else if (int.Parse(GrossSalary) > 1000)
            {
                if(int.Parse(GrossSalary) > 3000)
                {
                    excess = int.Parse(GrossSalary) - 3000;
                }
                SocialContribution = (int.Parse(GrossSalary) - 1000 - excess) * 15 / 100;
                tax = (int.Parse(GrossSalary) - 1000) * 10 / 100;
                NetSalary = int.Parse(GrossSalary) - (tax + SocialContribution);
                Console.WriteLine("The net amount of salary after taxation is: ");
                Console.WriteLine(NetSalary.ToString());
            }

            // This is the simplest variation i could think of . As for how new taxes can be added :
            // 1: They can be hardcoded
            // 2: Remake the program and make it to accept taxes as an input(A bit better i guess ?) or make them an optional input (EG: "Would you like to apply taxation to this salary ? etc " ) 
            // 3: Possibly pull the taxes from another source Maybe(Database ?  or API i am not too certain) 
        }
    }
}
