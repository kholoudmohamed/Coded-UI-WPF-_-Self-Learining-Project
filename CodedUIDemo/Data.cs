using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodedUIDemo
{
    public class Data
    {
        public static string AppPath => ConfigurationManager.AppSettings["AppPath"];
        public static string Username => ConfigurationManager.AppSettings["username"];
        public static string Password => ConfigurationManager.AppSettings["password"];
        public static string FirstName => ConfigurationManager.AppSettings["firstName"];


        // Random generators for new users
        public static string RandomLanguageGenerator
        {
            get
            {
                var languages = new List<string> { "English", "Spanish", "French", "Chinese" };
                var rnd = new Random();
                var r = rnd.Next(languages.Count);
                return languages[r];
            }          
        }
        public static string RandomUserNameGenerator => TestData.NewUser_UsernamePrefix +Stopwatch.GetTimestamp();
    }
}
