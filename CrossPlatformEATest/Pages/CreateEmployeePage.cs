using System;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using EAEmployeeTest.Pages;
using OpenQA.Selenium;

namespace CrossPlatformEATest.Pages
{
    internal class CreateEmployeePage : BasePage
    {
        public CreateEmployeePage(ParallelConfig parellelConfig) : base(parellelConfig) { }

        IWebElement txtName => parallelConfig.Driver.FindById("Name");

        IWebElement txtSalary => parallelConfig.Driver.FindById("Salary");

        IWebElement txtDurationWorked => parallelConfig.Driver.FindById("DurationWorked");

        IWebElement txtGrade => parallelConfig.Driver.FindById("Grade");

        IWebElement txtEmail => parallelConfig.Driver.FindById("Email");

        IWebElement btnCreateEmployee => parallelConfig.Driver.FindByXpath("//input[@value='Create']");


        internal EmployeeListPage ClickCreateButton()
        {
            btnCreateEmployee.Submit();
            return new EmployeeListPage(parallelConfig);
        }

        internal void CreateEmployee(string name, string salary, string durationworked, string grade, string email)
        {
            txtName.SendKeys(name);
            txtSalary.SendKeys(salary);
            txtDurationWorked.SendKeys(durationworked);
            txtGrade.SendKeys(grade);
            txtEmail.SendKeys(email);
        }
    }
}
