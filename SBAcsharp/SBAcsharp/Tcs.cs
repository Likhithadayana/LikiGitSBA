using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace SBAcsharp
{
    class Tcs : iGovernmentRules
    {

        public int empid { get; set; }

        public string ename { get; set; }

        public string dept { get; set; }

        public string desig { get; set; }

        public double basicsal { get; set; }

        public Tcs(int empid, string name, string dept, string desg, int basicsal)
        {
            this.ename = name;
            this.empid = empid;
            this.dept = dept;
            this.desig = desg;
            this.basicsal = basicsal;
           
        }
        public double gratuityAmt(float service, double basicSal)
        {
            if (service > 5)
            {
                return basicsal / 12;
            }
            else if (service > 10)
            {
                return 2 * basicsal;
            }
            else if (service > 20)
            {
                return 3 * basicsal;
            }
            else
            {
                return 0;
            }

        }

        public string Leave()
        {
            return "1 Casual Leave per month,12 days of Sick Leave per year,10 days of Previlage Leave per year";
        }

        public double PF(double basicSalary)
        {
            return (basicSalary * (0.12)) + (basicSalary * (0.0833)) + (basicSalary * (0.0367));
        }
    }
}





     