using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ToolLib
{
    public class CsTools
    {
        public static void Pause()
        {
            Console.WriteLine("\nPress Any Key To Continue . . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public class Validator
    {
        static string[] checkNumChars = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        static string[] checkLetter = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
        static string[] checkSpecial = { ",", ".", "<", ">", ";", ":", "\"", "'", "[", "{", "]", "}", "\\", "|", "_", "=", "+", ")", "(", "*", "&", "^", "%", "$", "#", "@", "!", "`", "~" };
        public bool isTelephone(String strCheck)
        {
            bool result = true;
            if (strCheck.Length >= 10)
            {
                foreach (string strChecker in checkLetter)
                {
                    if (strCheck.Contains(strChecker))
                        result = false;
                    else
                        result =  true;
                }
            }
            else
                result =  false;
            return result;
        }
        public bool isName(String strCheck)
        {
            bool result = true;
            foreach (string strChecker in checkSpecial)
            {
                if(strCheck.Contains(strChecker))
                {
                    result = false;
                }
            }
            foreach (string strCheckerTwo in checkNumChars)
            {
                if (strCheck.Contains(strCheckerTwo))
                {
                    result = false;
                }
            }
            return result;
        }
        public bool isZip(String strCheck)
        {
            bool result = true;
            foreach (string strChecker in checkSpecial)
            {
                if (strCheck.Contains(strChecker))
                {
                    result = false;
                }
            }
            foreach (string strCheckerTwo in checkLetter)
            {
                if (strCheck.Contains(strCheckerTwo))
                {
                    result = false;
                }
            }
            if (strCheck.Length != 5)
            {
                result = false;
            }
            return result;
        }
        public bool isState(String strCheck)
        {
            bool result = true;
            foreach (string strChecker in checkSpecial)
            {
                if (strCheck.Contains(strChecker))
                {
                    result = false;
                }
            }
            foreach (string strCheckerTwo in checkNumChars)
            {
                if (strCheck.Contains(strCheckerTwo))
                {
                    result = false;
                }
            }
            if (strCheck.Length < 2)
                result = false;
            return result;
        }
        public bool isFacebook(String strCheck)
        {
            bool result = false;
            string[] checker = { "facebook.com/", "fb.com/" };
            foreach (string strChecker in checker)
            {
                if (strCheck.Contains(strChecker))
                {
                    result = true;
                }
            }
            return result;
        }
        public bool isEmail(String strCheck)
        {
            bool result = true;
            try
            {
                MailAddress email = new MailAddress(strCheck);
                result = true;
            }
            catch (FormatException)
            {
                result = false;
            }
            return result;
        }
        public bool isPastDate (DateTime temp)
        {
            if (temp <= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
