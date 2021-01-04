using EAAutoFramework.Base;
using OpenQA.Selenium;
using EAAutoFramework.Extensions;
using System;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig) { }


        IWebElement txtUserName => parallelConfig.Driver.FindById("UserName");

        IWebElement txtPassword => parallelConfig.Driver.FindById("Password");

        IWebElement btnLogin => parallelConfig.Driver.FindByCss("input.btn");

        IWebElement btnLoginss => parallelConfig.Driver.FindByCss("input.btnssss");


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }


        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return new HomePage(parallelConfig);
        }


        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }

        internal BasePage ClickLoginButtons()
        {
            btnLoginss.Submit();
            return new HomePage(parallelConfig);
        }
    }
}
