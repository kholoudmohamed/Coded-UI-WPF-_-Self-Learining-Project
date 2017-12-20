using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUIDemo
{
    public class ATUUIMap
    {
        // Login Elements
        public static UITestControl AtuWindow
        {
            get
            {
                var atuWindow = new UITestControl { TechnologyName = "UIA" };
                atuWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Alaris Technical Utility";
                atuWindow.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
                atuWindow.WindowTitles.Add("Alaris Technical Utility");
                return atuWindow;
            }
        }
        public static WpfButton MaximizeBtn
        {
            get
            {
                var newBtn = new WpfButton(AtuWindow);
                newBtn.SearchProperties[UITestControl.PropertyNames.Name] = "Maximize";
                return newBtn;
            }
        }

        public static WpfImage CareFusionLogo
        {
            get
            {
                var newImg = new WpfImage(AtuWindow);
                newImg.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.Image";
                return newImg;
            }
        }

        public static WpfText LoginPageFirstTitle
        {
            get
            {
                var newTxt = new WpfText(AtuWindow);
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "Alaris Technical Utility";
                newTxt.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.TextBlock";
                return newTxt;
            }
        }
        public static WpfText LoginPageSecondTitle
        {
            get
            {
                var newTxt = new WpfText(AtuWindow);
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "Infusion Pump Management Tool";
                newTxt.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.TextBlock";
                return newTxt;
            }
        }
        public static WpfButton DbSettingsBtn
        {
            get
            {
                var newBtn = new WpfButton(AtuWindow);
                newBtn.SearchProperties[UITestControl.PropertyNames.Name] = "Advanced Database Setting";
                return newBtn;
            }
        }
        public static WpfText ForgetPasswordBtn
        {
            get
            {
                var newBtn = new WpfText(AtuWindow);
                newBtn.SearchProperties[UITestControl.PropertyNames.Name] = "Forgot password?";
                return newBtn;
            }
        }
        public static WpfText SuperAdminLoginPanel
        {
            get
            {
                var newTxt = new WpfText(AtuWindow);
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "SuperAdmin";
                return newTxt;
            }
        }
        public static WpfText SuperAdminSignOut
        {
            get
            {
                var newMenu = new WpfCustom(AtuWindow);
                newMenu.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.UserMenu";
                var newTxt = new WpfText(newMenu);

                newTxt.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.TextBlock";
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "Sign Out";        
                newTxt.SearchConfigurations.Add(SearchConfiguration.DisambiguateChild);
                return newTxt;
            }
        }
        public static WpfEdit UsernameTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(AtuWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "txtUsername";
                return newtxtBx;
            }
        }
        public static WpfEdit PasswordTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(AtuWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "txtPassword";
                return newtxtBx;
            }
        }
        public static WpfButton LoginBtn
        {
            get
            {
                var newBtn = new WpfButton(AtuWindow);
                newBtn.SearchProperties[UITestControl.PropertyNames.Name] = "Login";
                return newBtn;
            }
        }
        public static WpfText InvalidLoginMessage
        {
            get
            {
                var newTxt = new WpfText(AtuWindow);
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "Incorrect username or password";
                return newTxt;
            }
        }
        public static WpfText LoggedInUserName
        {
            get
            {
                var newTxt = new WpfText(AtuWindow);
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "SuperAdmin";
                return newTxt;
            }
        }

        // User Management Elements
        public static WpfText UserManagementTitle
        {
            get
            {
                var newTxt = new WpfText(AtuWindow);
                newTxt.SearchProperties[UITestControl.PropertyNames.Name] = "User Management";
                return newTxt;
            }
        }
        public static WpfButton NewUserBtn
        {
            get
            {
                var newBtn = new WpfButton(AtuWindow);
                newBtn.SearchProperties[UITestControl.PropertyNames.Name] = "New";
                return newBtn;
            }
        }
        public static WpfCustom AtuSubWindow
        {
            get
            {
                var newWindow = new WpfCustom(AtuWindow);
                newWindow.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.Home";
                newWindow.WindowTitles.Add("Alaris Technical Utility");
                return newWindow;
            }
        }
        public static WpfCustom NewUserWindow
        {
            get
            {
                var newWindow = new WpfCustom(AtuSubWindow);
                newWindow.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.Register";
                newWindow.WindowTitles.Add("Alaris Technical Utility");
                return newWindow;
            }
        }
        public static WpfEdit NewUser_FirstNameTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(NewUserWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "FirstNameTxtBox";
                return newtxtBx;
            }
        }
        public static WpfEdit NewUser_LastNameTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(NewUserWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "LastNameTxtBox";
                return newtxtBx;
            }
        }
        public static WpfEdit NewUser_UserNameTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(NewUserWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "UserNameTxtBox";
                return newtxtBx;
            }
        }
        public static WpfEdit NewUser_PasswordTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(NewUserWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "PasswordTxtBox";
                return newtxtBx;
            }
        }
        public static WpfEdit NewUser_ReTypePasswordTxtBx
        {
            get
            {
                var newtxtBx = new WpfEdit(NewUserWindow);
                newtxtBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "ConfirmPasswordTxtBox";
                return newtxtBx;
            }
        }
        public static WpfComboBox NewUser_LanguageDrpDwn
        {
            get
            {
                var newCmboBx = new WpfComboBox(NewUserWindow);
                newCmboBx.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "LanguageComboBox";
                return newCmboBx;
            }
        }
        public static WpfListItem NewUser_LanguageEnglishOption
        {
            get
            {
                var newListItem = new WpfListItem(AtuWindow);
                newListItem.SearchProperties[WpfListItem.PropertyNames.Name] = "[0, English]";              
                return newListItem;
            }
        }
        public static WpfButton NewUser_SaveBtn
        {
            get
            {
                var newBtn = new WpfButton(AtuWindow);
                newBtn.SearchProperties[UITestControl.PropertyNames.Name] = "Save";
                return newBtn;
            }
        }
        // Displayed users data
        public static WpfTable UsersTable
        {
            get
            {
                var newTable = new WpfTable(AtuWindow);
                newTable.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.DataGrid";
                return newTable;
            }
        }
        public static WpfText TextInTable (string txt)
        {
            var newTxt = new WpfText(UsersTable);
            newTxt.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.TextBlock";
            newTxt.SearchProperties[UITestControl.PropertyNames.Name] = txt;
            return newTxt;
        }
        public static WpfImage NewUserNotificationCloseBtn
        {
            get
            {
                var newImg = new WpfImage(AtuWindow);
                newImg.SearchProperties[WpfImage.PropertyNames.AutomationId] = "ClosaImage";
                return newImg;
            }
        }
        public static WpfCustom ChangePasswordWindow
        {
            get
            {
                var newWindow = new WpfCustom(AtuWindow);
                newWindow.SearchProperties[WpfCustom.PropertyNames.AutomationId] = "ChangePasswordControl";
                return newWindow;
            }
        }


    }
}
