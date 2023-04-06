using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.Interface
{
    interface IAccident_claim_info
    {
        void SetPolicyNumber(string policynumber);
        string GetPolicyNumber();

        void SetDriversLicenseNumber(string driverslincensenumber);
        string GetDriversLicenseNumber();

        void SetTimeofAccident(string timeofaccident);
        string GetTimeofAccident();

    }
}
