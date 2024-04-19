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

        driver.Navigate().GoToUrl("https://www.hilokal.com/en"); 

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement loginButton = wait.Until(driver => driver.FindElement(By.XPath("//button[text()='Login']")));
        loginButton.Click();
     
      IWebElement usernameField = wait.Until(driver => driver.FindElement(By.Id("aksharvekariya786@gmail.com")));
        usernameField.SendKeys("your_username"); 

       IWebElement passwordField = wait.Until(driver => driver.FindElement(By.Id("Akshar@786")));
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



    // Test Case for Search Bar

    using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HilokalSearchTest
{
    class Program
    {
        static void Main(string[] args)
        {
          
            IWebDriver driver = new ChromeDriver();

            
            driver.Navigate().GoToUrl("https://www.hilokal.com/login");

           
       
            driver.FindElement(By.Id("username")).SendKeys("aksharvekariya786@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Akshar@786");
            driver.FindElement(By.Id("loginButton")).Click();

           
            System.Threading.Thread.Sleep(2000);

            
            IWebElement searchBar = driver.FindElement(By.Id("searchInput"));

            searchBar.Clear();

           
            searchBar.SendKeys("Cultural Exchange");

        
            searchBar.SendKeys(Keys.Enter);

           
            System.Threading.Thread.Sleep(3000);

          
            IWebElement searchResults = driver.FindElement(By.Id("searchResults"));
            if (searchResults.Displayed)
            {
                Console.WriteLine("Search test passed: Search results displayed.");
            }
            else
            {
                Console.WriteLine("Search test failed: Search results not displayed.");
            }

           
            driver.Quit();
        }
    }
}

