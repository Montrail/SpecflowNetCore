using CrossPlatformEATest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {

        public EmployeeListPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement txtSearch => parallelConfig.Driver.FindElement(By.Name("searchTerm"));

        IWebElement lnkCreateNew => parallelConfig.Driver.FindElement(By.LinkText("Create New"));

        IWebElement lnkCreateNewss => parallelConfig.Driver.FindElement(By.LinkText("Create Newsssssss"));

        IWebElement tblEmployeeList => parallelConfig.Driver.FindElement(By.ClassName("table"));

        IWebElement lnkLogoff => parallelConfig.Driver.FindElement(By.LinkText("Log off"));

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage(parallelConfig);
        }

        public CreateEmployeePage ClickCreateNews()
        {
            lnkCreateNewss.Click();
            return new CreateEmployeePage(parallelConfig);
        }


        public IWebElement GetEmployeeList()
        {
            return tblEmployeeList;
        }

        internal void ClickLogoff()
        {
            lnkLogoff.Click();
        }
    }
}
