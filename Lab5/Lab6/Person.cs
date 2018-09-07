using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolLib;

namespace PersonLib
{
    public class Person : Validator
    {
        private String firstName;
        private String middleName;
        private String lastName;
        private String streetOne;
        private String streetTwo;
        private String cityStr;
        private String stateStr;
        private String zipStr;
        private String homePhoneStr;
        private String emailStr;

        public String FirstName
        {
            get { return firstName; }
            set
            {
                string temp;
                bool result = isName(value);
                if (result == true)
                    firstName = value;
                else
                {
                    temp = value;
                    firstName = "ERROR: " + temp;
                }
            }
        }
        public String MiddleName
        {
            get { return middleName; }
            set
            {
                string temp;
                bool result = isName(value);
                if (result == true)
                    middleName = value;
                else
                {
                    temp = value;
                    middleName = "ERROR: " + temp;
                }
            }
        }
        public String LastName
        {
            get { return lastName; }
            set
            {
                string temp;
                bool result = isName(value);
                if (result == true)
                    lastName = value;
                else
                {
                    temp = value;
                    lastName = "ERROR: " + temp;
                }
            }
        }
        public String StreetOne
        {
            get { return streetOne; }
            set { streetOne = value; }
        }
        public String StreetTwo
        {
            get { return streetTwo; }
            set { streetTwo = value; }
        }
        public String CityStr
        {
            get { return cityStr; }
            set
            {
                string temp;
                bool result = isState(value);
                if (result == true)
                    cityStr = value;
                else
                {
                    temp = value;
                    cityStr = "ERROR: " + temp;
                }
            }
        }
        public String StateStr
        {
            get { return stateStr; }
            set
            {
                string temp;
                bool result = isState(value);
                if (result == true)
                    stateStr = value;
                else
                {
                    temp = value;
                    stateStr = "ERROR: " + temp;
                }
            }
        }
        public String ZipStr
        {
            get { return zipStr; }
            set
            {
                string temp;
                bool result = isZip(value);
                if (result == true)
                    zipStr = value;
                else
                {
                    temp = value;
                    zipStr = "ERROR: " + temp;
                }
            }
        }
        public String PhoneStr
        {
            get { return homePhoneStr; }
            set
            {
                string temp;
                bool result = isTelephone(value);
                if (result == true)
                    homePhoneStr = value;
                else
                {
                    temp = value;
                    homePhoneStr = "ERROR: " + temp;
                }
            }
        }
        public String EmailStr
        {
            get { return emailStr; }
            set
            {
                string temp;
                bool result = isEmail(value);
                if (result == true)
                    emailStr = value;
                else
                {
                    temp = value;
                    emailStr = "ERROR: " + temp;
                }
            }
        }
    }
}
