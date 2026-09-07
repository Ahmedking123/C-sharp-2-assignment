using System.Reflection;
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
        }
    }
}
