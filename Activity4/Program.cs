using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;



namespace Activity4
{
class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver(); // You need to have Chrome WebDriver installed and in PATH

        driver.Navigate().GoToUrl("https://example.com"); // Replace "https://example.com" with the actual URL of the Hilokal mobile application

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement loginButton = wait.Until(driver => driver.FindElement(By.XPath("//button[text()='Login']")));
        loginButton.Click();
     
      IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
        usernameField.SendKeys("your_username"); // Replace "your_username" with the actual username

       IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
       passwordField.SendKeys("your_password"); // Replace "your_password" with the actual password
       loginButton = wait.Until(driver => driver.FindElement(By.XPath("//button[text()='Login']")));
       loginButton.Click();

        wait.Until(driver => driver.Url.Contains("home")); // Assuming the URL changes to include "home" upon successful login
         if (driver.Url.Contains("home"))
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
        driver.Quit();
    }
}
}