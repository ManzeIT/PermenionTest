using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace PermenionTestTask.Utility
{
    class Setup
    {
        IWebDriver driver;
        string baseUrl = "http://localhost:51077/";

        public void LaunchApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
            //THis is static wait(Implicit wait). A dynamic (Explicit wait can also be implemented using WebDriver wait
            
            Thread.Sleep(2000);
        }

        public void FieldOneOperation(string firstData)
        {
            IWebElement firstDataField = driver.FindElement(By.Id("Numerator"));
            firstDataField.Clear();
            firstDataField.SendKeys(firstData);
        }

        public void FieldTwoOperation(string secondData)
        {           

            IWebElement secondDataField = driver.FindElement(By.Id("Denominator"));
            secondDataField.Clear();
            secondDataField.SendKeys(secondData);           
        }

        public void DivisionButtonOperation()
        { 

            driver.FindElement(By.Id("Submit")).Click();            
        }

        public int ActualResult()
        {
            //
            //Selenium WebDriver cannot currently interact with 
            //the result data because it is not an html element
            //I have decided to hardcode actual result and return it 
            //back to step definition
            return 2;         
        }

        public void ShutDown()
        {
            driver.Close();
        }


    }
}
