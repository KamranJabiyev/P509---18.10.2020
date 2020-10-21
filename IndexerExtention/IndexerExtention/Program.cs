using IndexerExtention.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention
{
    class Program
    {
        public enum Weekday{ Monday=1,Tuesday,Wednesday,Thursday=10,Friday,Saturday=255,Sunday};
        public enum Errors { NotFound=404,ServerSideError=500};
        public enum UserLevel { Admin,Manager,Moderator,Simple};
        static void Main(string[] args)
        {
            #region Nullable value type
            //Console.WriteLine(Difference(10,null));

            //int? a = 5;
            //a = null;
            #endregion

            #region Enum
            //foreach (var item in Enum.GetValues(typeof(UserLevel)))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine((int)Weekday.Monday);

            //int day = 3;

            //switch (day)
            //{
            //    case (int)Weekday.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case (int)Weekday.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case (int)Weekday.Wednesday:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("Other day");
            //        break;
            //}
            #endregion

            #region Indexer
            //Book book = new Book("Xemse", 1000);
            //Book book1 = new Book("Sefiller",13);

            //Library library = new Library("Libraf");
            ////library.AddBook(book);
            ////library.AddBook(book1);
            //library[0] = book;
            //library[1] = book1;
            //Console.WriteLine(library[100]);
            #endregion

            #region Extention
            //string email = "kamran.jabiyev@code.edu.az";
            //Console.WriteLine(email.IsEmail());
            //Console.WriteLine(Extention.IsEmail(email));
            //Console.WriteLine(IsMail(email));

            //double num = 5;
            //Console.WriteLine(num.GetPower(3));

            //const int x = 5;

            string word = "Hello World";
            Console.WriteLine(word.LetterCount('l'));
            
            #endregion
        }

        //public static bool IsMail(string mail)
        //{
        //    try
        //    {
        //        MailAddress email = new MailAddress(mail);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        #region Nullable value type
        //static int Difference(int x,int? y)
        //{
        //    if (y == null)
        //    {
        //        return x;
        //    }
        //    return x - (int)y;
        //}
        #endregion
    }
}
