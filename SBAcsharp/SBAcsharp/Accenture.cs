using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBAcsharp
{
    class Accenture : iGovernmentRules
    {

        public int empid { get; set; }

        public string ename { get; set; }

        public string dept { get; set; }

        public string desig { get; set; }

        public double basicsal { get; set; }

        public Accenture(int empid, string name, string dept, string desg, int basicsal)
        {
            this.empid = empid;
            this.ename = name;
            this.empid = empid;
            this.dept = dept;
            this.desig = desg;
            this.basicsal = basicsal;

        }

        public double gratuityAmt(float service, double basicSal)
        {
            throw new NotImplementedException();
        }

        public string Leave()
        {
            return "2  Casual Leave per month,5 Sick Leave per year,5 Previlage Leave per year ";
        }

        public double PF(double basicSalary)
        {
            return (basicsal * (0.12)) + (10000 * (0.12));
        }
    }
}
