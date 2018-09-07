using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;

namespace PersonLibV2
{
    class PersonV2 : Person
    {
        private String cellPhone;
        private String faceBook;
        public int Person_ID;
        public String CellPhone
        {
            get { return cellPhone; }
            set
            {
                string temp;
                bool result = isTelephone(value);
                if (result == true)
                    cellPhone = value;
                else
                {
                    temp = value;
                    cellPhone = "ERROR: " + temp;
                }
            }
        }
        public String FaceBook
        {
            get { return faceBook; }
            set 
            {
                string temp;
                bool result = isFacebook(value);
                if (result == true)
                    faceBook = value;
                else
                {
                    temp = value;
                    faceBook = "ERROR: " + temp;
                }
            }
        }
    
    }
}
