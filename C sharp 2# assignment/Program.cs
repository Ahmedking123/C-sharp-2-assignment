using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace C_sharp_2__assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First question

            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion

            #region Second question

            string str1 = "Clean Code";
            string str2 = "Clean Code";

            Console.WriteLine(object.ReferenceEquals(str1,str2));

            #endregion

            #region Third question

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("- Updated");
            Console.WriteLine(sb.ToString());

            #endregion

            #region Fourth question

            int Pages = 464;
            new string("Book: " + str1 + " Pages: " + Pages);

            #endregion

            #region Fifth question

            new string($"Book: {str1} Pages: {Pages}");

            #endregion

            #region Sixth question

            string.Format("Book: {0} Pages: {1}", str1, Pages);

            #endregion

            #region Seventh question

            if (Pages > 300)
            {
                Console.WriteLine("Long book");
            }
            else
            {
                Console.WriteLine("Short book");
            }

            #endregion

            #region Eighth question

            bool IsAvailable = true;

            if (IsAvailable && Pages > 300)
            {
                Console.WriteLine("Youu can borrow this book");
            }
            #endregion

            #region Ninth question

            title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great Choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion

            #region Tenth question

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());

            #endregion

        }
    }
}
