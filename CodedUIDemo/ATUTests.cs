using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Threading;
using System.Windows.Input;

namespace CodedUIDemo
{
    [CodedUITest]
    public class ATUTests
    {
        private readonly ATUActions _actions = new ATUActions();
        [TestInitialize]
        public void Initialize()
        {
            _actions.CloseAppIfOpen();
            ApplicationUnderTest.Launch(Data.AppPath);
            _actions.MaximizeAppWindow();
        }

        [TestMethod]
        public void VerifyLoginPageElements()
        {
            Assert.IsTrue(ATUUIMap.CareFusionLogo.Exists,"Carefusion logo is not exist in the Login Page");

            Assert.IsTrue(ATUUIMap.LoginPageFirstTitle.Exists,"Login Page Alaris First Title is not displayed");
            Assert.AreEqual(TestData.LoginPage_FirstTitle, _actions.Get_LoginPageFirstTitleTxt(), "Login Page Alaris First Title is not corect");

            Assert.IsTrue(ATUUIMap.LoginPageSecondTitle.Exists, "Login Page Alaris Second Title is not displayed");
            Assert.AreEqual(TestData.LoginPage_SecondTitle, _actions.Get_LoginPageSecondTitleTxt(), "Login Page Alaris Second Title is not corect");

            Assert.IsTrue(ATUUIMap.UsernameTxtBx.Exists, "Username text box is not displayed");
            Assert.IsTrue(ATUUIMap.UsernameTxtBx.Enabled,"Username text box is not enabled");

            Assert.IsTrue(ATUUIMap.PasswordTxtBx.Exists, "Password text box is not displayed");
            Assert.IsTrue(ATUUIMap.PasswordTxtBx.Enabled, "Password text box is not enabled");

            Assert.IsTrue(ATUUIMap.LoginBtn.Exists, "Login Button is not displayed");
            Assert.IsFalse(ATUUIMap.LoginBtn.Enabled, "Login Button should be disabled");

            Assert.IsTrue(ATUUIMap.DbSettingsBtn.Exists, "Advanced Database Settings link is not displayed");
            Assert.IsTrue(ATUUIMap.DbSettingsBtn.Enabled, "Advanced Database Settings link is not enabled");

            Assert.IsTrue(ATUUIMap.ForgetPasswordBtn.Exists, "Forget Password link is not displayed");
            Assert.IsTrue(ATUUIMap.ForgetPasswordBtn.Enabled, "Forget Password link is not enabled");
        }

        [TestMethod]
        public void Login()
        {

            _actions.TypeIn_UsernameAndPassword(Data.Username,Data.Password);
            _actions.ClickOn_Login();

            Assert.AreEqual(Data.FirstName,_actions.Get_LoggedInUserName(),"Super Admin User is not logged in!");
        }

        [TestMethod]
        public void InvalidLogin()
        {
            _actions.TypeIn_UsernameAndPassword(TestData.InvalidUsername, TestData.InvalidPassword);
            _actions.ClickOn_Login();

            Assert.AreEqual(TestData.InvalidLoginErrorMessage, _actions.Get_InvalidLoginErrorMessage(), "Login Error Message is not correct");
        }

        [TestMethod]
        public void CreateNewUser()
        {
            _actions.TypeIn_UsernameAndPassword(Data.Username, Data.Password);
            _actions.ClickOn_Login();

            _actions.ClickOn_NewUser();

            var lang = Data.RandomLanguageGenerator;
            var username = Data.RandomUserNameGenerator;

            _actions.FillIn_NewUserData(TestData.NewUser_FirstName, TestData.NewUser_LastName, username, TestData.NewUser_Password, lang);
            
            _actions.ClickOn_CloseNewUserNotificationPopup();

            _actions.SuperAdminSignOut();

            _actions.TypeIn_UsernameAndPassword(username, TestData.NewUser_Password);
            _actions.ClickOn_Login();

            Assert.IsTrue(ATUUIMap.ChangePasswordWindow.Exists,"Change Password Window is not displayed");
        }


        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }
    }
}
