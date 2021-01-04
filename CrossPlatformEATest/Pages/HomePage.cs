using System;
using System.Data;
using System.Linq;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class HomePage : BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement lnkLogin => parallelConfig.Driver.FindByLinkText("Login");

        IWebElement lnkEmployeeList => parallelConfig.Driver.FindByLinkText("Employee List");

        IWebElement lnkLoggedInUser => parallelConfig.Driver.FindByXpath("//a[@title='Manage']");

        IWebElement lnkLogoff => parallelConfig.Driver.FindByLinkText("Log off");


        internal void CheckIfLoginExist()
        {
            lnkLogin.AssertElementPresent();
        }


        internal LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return new LoginPage(parallelConfig);
        }

        internal string GetLoggedInUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }

        public EmployeeListPage ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return new EmployeeListPage(parallelConfig);
        }

        public LoginPage ClickLogOff()
        {
            lnkLogoff.Click();
            return new LoginPage(parallelConfig);
        }
    }
}
