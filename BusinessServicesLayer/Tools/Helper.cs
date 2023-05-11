using OnlineExamSystem.BusinessServicesLayer;
using OnlineExamSystem.DataServicesLayer.Model.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;



namespace OnlineExamSystem
{
    public class Helper
    {
        public static bool VerifyPassword(string password, string storedHash)
        {
            // Compare the provided password with the stored hash
            bool isVerified = BC.Verify(password, storedHash);
            return isVerified;
        }

        public static string HashPassword(string password)
        {
            // Generate a salted and hashed password using the default work factor
            string hashedPassword = BC.HashPassword(password);
            return hashedPassword;
        }

        public static string GetAccRoleString(int Role)
        {
            AccRole x = (AccRole)Enum.ToObject(typeof(AccRole), Role);
            return x.ToString();
        }
        public static void ExitProcess()
        {
            Environment.Exit(0);
        }
    }
}
