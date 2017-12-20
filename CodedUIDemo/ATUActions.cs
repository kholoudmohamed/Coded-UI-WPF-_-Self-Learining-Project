using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUIDemo
{
    public class ATUActions
    {
        // Common Actions
        public void CloseAppIfOpen()
        {
            var localByName = Process.GetProcessesByName("ATU");
            foreach (var item in localByName)
            {
                item.Kill();
            }
        }
        public void MaximizeAppWindow()
        {
            Mouse.Click(ATUUIMap.MaximizeBtn);
        }
        // Login Page Actions
        public string Get_LoginPageFirstTitleTxt()
        {
            return ATUUIMap.LoginPageFirstTitle.GetProperty("DisplayText").ToString();
        }
        public string Get_LoginPageSecondTitleTxt()
        {
            return ATUUIMap.LoginPageSecondTitle.GetProperty("DisplayText").ToString();
        }
        public void TypeIn_UsernameAndPassword(string username,string password)
        {
            Keyboard.SendKeys(ATUUIMap.UsernameTxtBx, username);
            Keyboard.SendKeys(ATUUIMap.PasswordTxtBx, password);
        }
        public void ClickOn_Login()
        {
            Mouse.Click(ATUUIMap.LoginBtn);
        }
        public string Get_InvalidLoginErrorMessage()
        {
            return ATUUIMap.InvalidLoginMessage.GetProperty("DisplayText").ToString();
        }
        public string Get_LoggedInUserName()
        {
            return ATUUIMap.LoggedInUserName.GetProperty("DisplayText").ToString();
        }

        public void SuperAdminSignOut()
        {
            Mouse.Click(ATUUIMap.SuperAdminLoginPanel);
            Mouse.Click(ATUUIMap.SuperAdminSignOut.BoundingRectangle.Location);
        }
        public void ClickOn_CloseNewUserNotificationPopup()
        {
            Mouse.Click(ATUUIMap.NewUserNotificationCloseBtn);
        }

        // User Mangement Actions
        public string Get_UserManagementTitle()
        {
            return ATUUIMap.UserManagementTitle.GetProperty("DisplayText").ToString();
        }
        public void ClickOn_NewUser()
        {
            Mouse.Click(ATUUIMap.NewUserBtn);
        }

        public void SelectLang(string lang)
        {
            switch (lang)
            {
                case "English":
                    ATUUIMap.NewUser_LanguageDrpDwn.SelectedItem = "[0, " + lang + "]";
                    break;
                case "Spanish":
                    ATUUIMap.NewUser_LanguageDrpDwn.SelectedItem = "[1, " + lang + "]";
                    break;
                case "French":
                    ATUUIMap.NewUser_LanguageDrpDwn.SelectedItem = "[2, " + lang + "]";
                    break;
                case "Chinese":
                    ATUUIMap.NewUser_LanguageDrpDwn.SelectedItem = "[3, " + lang + "]";
                    break;
            }
        }

        public void FillIn_NewUserData(string firstName, string lastName, string userName, string password,
            string language)
        {
            Keyboard.SendKeys(ATUUIMap.NewUser_FirstNameTxtBx,firstName);
            Keyboard.SendKeys(ATUUIMap.NewUser_LastNameTxtBx, lastName);
            Keyboard.SendKeys(ATUUIMap.NewUser_UserNameTxtBx, userName);
            Keyboard.SendKeys(ATUUIMap.NewUser_PasswordTxtBx, password);
            Keyboard.SendKeys(ATUUIMap.NewUser_ReTypePasswordTxtBx, password);
            SelectLang(language);
            //Mouse.Click(ATUUIMap.NewUser_LanguageDrpDwn);
            //Mouse.Click(ATUUIMap.NewUser_LanguageEnglishOption);
            Mouse.Click(ATUUIMap.NewUser_SaveBtn);

        }
    }
}
