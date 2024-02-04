using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week3Homework
{
    internal class Program
    {
        static bool Main(string[] args)
        {
            
            {
                float totalSalary;
                char familyStatus;
                int childnumber;
                char personHealth;
                
                Console.WriteLine("Enter Salary:");
                totalSalary = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Family status:(M/S/W)");
                familyStatus = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of childs:");
                childnumber=int.Parse(Console.ReadLine());
                Console.WriteLine("Are you disable?(Y/N):");
                personHealth = char.Parse(Console.ReadLine());

                string status;
                if (familyStatus == 'M' || familyStatus == 'S' || familyStatus == 'W') { status = "Give us disable report:"; }
                else if { status == "You are single"; }
                else { status = "You are happy;"; }


                string disable;
                if (personHealth == 'Y' || personHealth == 'M') { disable = "Give us disable report:"; }
                else { disable = "You are good:"; }


            }
        }
    }

}
    

