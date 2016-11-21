using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

namespace Demo.SeleniumTest
{
    public class UnitTesCase
    {
        public void VisitCnblogs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.cnblogs.com/lucky_hu/";
            var lnkAutomation = driver.FindElement(By.XPath(".//div[@id='side-categories']/ul/li/a[text()='自动化测试']"));
            lnkAutomation.Click();
        }
    }
}
