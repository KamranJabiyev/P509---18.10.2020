using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention.Extentions
{
    public static class Extention
    {
        public static bool IsEmail(this string email)
        {
			try
			{
				MailAddress mail = new MailAddress(email);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
        }

		public static double GetPower(this double number, double power)
		{
			return Math.Pow(number, power);
		}

		public static int LetterCount(this string word,char l)
		{
			int result = 0;
			foreach (char item in word)
			{
				if (item == l)
					result++;
			}
			return result;
		}
    }
}
