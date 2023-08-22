using August2023.Pages;
using August2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2023.Tests
{
    [Parallelizable]
    [TestFixture]
    public class EmployeesTests : CommonDriver
    {
        [SetUp]
        public void EmployeesSetUp()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeesPage(driver);
        }

        [Test]
        public void CreateEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee_Test()
        {
            EmployeesPage employeesPage = new EmployeesPage();
            employeesPage.DeleteEmployee(driver);
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
        
    }
}
