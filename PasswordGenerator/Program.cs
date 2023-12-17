using System.Text;

namespace PasswordGenerator
{
    internal class Program
    {
        
    
        static string GenerateRandomPassword(int length,bool upper,bool lower, bool numbers, bool symbols)
        {
            var userChoice = new StringBuilder();
            var password = new StringBuilder();
            var rnd = new Random();
            #region Conditions
            if (upper == true)
                userChoice.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            if (lower == true)
                userChoice.Append("abcdefghijklmnopqrstuvwxyz");

            if (numbers == true)
                userChoice.Append("0123456789");

            if (symbols == true)
                userChoice.Append("!@#$%^&*()"); 
            #endregion

            for (int i = 1; i <= length; i++)
            {
                password.Append(userChoice[rnd.Next(0, userChoice.Length - 1)]);
            }

            return password.ToString();
        }
        static void Main(string[] args)
        {
            int passwordLength;
            bool containsUpperLetters;
            bool containsLowerLetters;
            bool containsNumbers;
            bool containsSymbols;

            bool flag;
            do
            {
                Console.Write("Enter the password length: ");
                flag = int.TryParse(Console.ReadLine(), out passwordLength);
            }
            while (!flag);

            do
            {
                Console.Write("(Please write true or false for your choice)Is the password Contains Upper Letters: ");
                flag = bool.TryParse(Console.ReadLine(), out containsUpperLetters);
            }
            while (!flag);
            do
            {
                Console.Write("(Please write true or false for your choice)Is the password Contains Lower Letters: ");
                flag = bool.TryParse(Console.ReadLine(), out containsLowerLetters);
            }
            while (!flag);
            do
            {
                Console.Write("(Please write true or false for your choice)Is the password Contains Numbers: ");
                flag = bool.TryParse(Console.ReadLine(), out containsNumbers);
            }
            while (!flag);
            do
            {
                Console.Write("(Please write true or false for your choice)Is the password Contains Symbols: ");
                flag = bool.TryParse(Console.ReadLine(), out containsSymbols);
            }
            while (!flag);

            Console.WriteLine(GenerateRandomPassword(passwordLength, containsUpperLetters, containsLowerLetters, containsNumbers, containsSymbols));
        }
    }
}
