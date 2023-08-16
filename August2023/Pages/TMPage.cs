using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2023.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // Select Time from dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeTypeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeTypeCode.Click();

            // Enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("August2023");

            // Enter description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("August2023");

            // Enter price
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(5000);

            // Check if new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "August2023")
            {
                Console.WriteLine("New Time record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Time record has not been created.");
            }
        }

        public void EditTimeRecord(IWebDriver driver)
        {
            // Code for edit time record
        }

        public void DeleteTimeRecord(IWebDriver driver)
        {
            // Code for delete time record
        }
    }
}
