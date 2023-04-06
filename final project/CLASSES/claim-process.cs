using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.CLASSES
{
    class claim_process:final_project.Interface.Iclient,final_project.Interface.IAccident_claim_info
    {
        string firstName;
        string lastName;
        string gender;
        string email;
        string city;
        string streetaddress;
        string phonenumber;
        string policynumber;
        string driverslicensenumber;
        string timeofaccident;
        string formalname;


      public string GetFirstName()
        {
            return firstName;
        }

        public string GetGender()
        {
            return gender;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetEmail()
        {
            return email;
        }

        public string Getcity()
        {
            return city;
        }

        public string GetStreetAddress()
        {
            return streetaddress;
        }

        public string GetPhoneNumber()
        {
            return phonenumber;
        }

        public string GetPolicyNumber()
        {
            return policynumber;
        }

        public string GetDriversLicenseNummber()
        {
            return driverslicensenumber;
        }

        public string GetTimeofAccident()
        {
            return timeofaccident;
        }

        public string GetFormalName()
        {
             return formalname;
        }
        }

    }

