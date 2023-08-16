using August2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //Open the Browser
        IWebDriver driver = new ChromeDriver();

        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        // Home page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        // Tm page object initialization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);

        tmPageObj.EditTimeRecord(driver);

        tmPageObj.DeleteTimeRecord(driver);
    }
}