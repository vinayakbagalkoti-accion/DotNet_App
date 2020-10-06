using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFunctionalTests
{
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
        }

        //test

        [Test]
        public void Test1()
        {
            try
            {
                driver.Navigate().GoToUrl("https://localhost:4433/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                String ActualTitle = driver.Title;
                String ExpectedTitle = "Home Page - My ASP.NET Application";
                Assert.AreEqual(ActualTitle, ExpectedTitle);
                driver.Dispose();
            }
            catch (Exception ex)
            {
                driver.Dispose();
            }
            finally
            {
                driver.Dispose();
            }
        }

        // Testing whether the Home link exits or not

        //[Test]
        //public void Test2()
        //{
        //    driver.Navigate().GoToUrl("http://3.128.91.93/WebApplication1_Deploy");
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);
        //    //driver.FindElement(By.XPath("//*[contains(text(),'MVC_Core_NUnit')]")).Click();
        //    //String ActualTitle = driver.FindElement(By.XPath("//*[contains(text(),'Home')]")).Text;
        //    String ActualTitle = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[1]/a")).Text;
        //    String ExpectedTitle = "Home";
        //    Assert.AreEqual(ExpectedTitle, ActualTitle);
        //    driver.Close();
        //}

        //[Test]
        //public void Test3()
        //{
        //    driver.Navigate().GoToUrl("http://3.128.91.93/WebApplication1_Deploy");
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);
        //    driver.FindElement(By.XPath("//*[contains(text(),'Privacy')]")).Click();
        //    Thread.Sleep(2000);
        //    //driver.FindElement(By.XPath("//*[contains(text(),'Privacy')]")).Click();

        //    //string text = driver.FindElement(By.XPath("/html/body/div/main/h1")).Text;

        //    // Console.WriteLine(text);

        //    // Console.WriteLine(driver.FindElement(By.XPath("/html/body/div/main/h1")).Text);

        //    String ActualTitle = driver.FindElement(By.XPath("/html/body/div/main/h1")).Text;
        //    String ExpectedTitle = "Privacy Policy";
        //    Assert.AreEqual(ExpectedTitle, ActualTitle);
        //    driver.Close();
        //    //Assert.Pass();

        //}

        //[Test]
        //public void Test4()
        //{
        //    driver.Navigate().GoToUrl("https://localhost:44371");
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);
        //    String ActualTitle = driver.FindElement(By.XPath("/html/body/div/main/div/h1")).Text;
        //    String ExpectedTitle = "Welcome Anoop";
        //    Assert.AreEqual(ExpectedTitle, ActualTitle);
        //    driver.Close();
        //}



        //[Test]
        //public void Test5()
        //{
        //    driver.Navigate().GoToUrl("https://localhost:44371");
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);
        //    String ActualTitle = driver.FindElement(By.XPath("/html/body/div/main/div/table/tbody/tr[1]/td[1]/span/b")).Text;
        //    String ExpectedTitle = "Employe ID:";
        //    Assert.AreEqual(ExpectedTitle, ActualTitle);
        //    driver.Close();
        //}



        //[Test]
        //public void Test6()
        //{

        //    driver.Navigate().GoToUrl("https://localhost:44371");
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);
        //    String ActualTitle = driver.FindElement(By.XPath("/html/body/div/main/div/table/tbody/tr[1]/td[2]")).Text;
        //    String ExpectedTitle = "3236";
        //    Assert.AreEqual(ExpectedTitle, ActualTitle);
        //    driver.Close();
        //}        


        /*[Test]

        public void Test2()

        {

            driver.Navigate().GoToUrl("https://twitter.com/login");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

            driver.Close();

            //Assert.Pass();

        }

        [Test]

        public void Test3()

        {

            driver.Navigate().GoToUrl("https://google.com/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

            driver.Close();

            //Assert.Pass();

        }

        */

    }
}
