using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBAcsharp
{
    interface iGovernmentRules
    {

        double PF(double basicSalary);
        string Leave();
        double gratuityAmt(float service, double basicSal);

    }
}
