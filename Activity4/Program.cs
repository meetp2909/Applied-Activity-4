﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;



namespace Activity4
{
class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver(); 

        driver.Navigate().GoToUrl("https://example.com"); 

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement loginButton = wait.Until(driver => driver.FindElement(By.XPath("//button[text()='Login']")));
        loginButton.Click();
     
      IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("username")));
        usernameField.SendKeys("your_username"); 

       IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("password")));
       passwordField.SendKeys("your_password"); 
       loginButton = wait.Until(driver => driver.FindElement(By.XPath("//button[text()='Login']")));
       loginButton.Click();

        wait.Until(driver => driver.Url.Contains("home")); 
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