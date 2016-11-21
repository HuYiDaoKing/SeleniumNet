using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.SeleniumTest.Winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitCnblogs();
        }

        #region Private
        public void VisitCnblogs()
        {
            //IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new InternetExplorerDriver();

            driver.Url = "http://www.cnblogs.com/NorthAlan";
            var lnkAutomation = driver.FindElement(By.XPath(".//div[@id='sidebar_postcategory']/ul/li/a[text()='单元测试 - xUnit.Net(6)']"));
            lnkAutomation.Click();
            //btnZzk
            //var txtQ = driver.FindElement(By.Id("q"));
            //txtQ.SendKeys("C#");
            //var btnZzk = driver.FindElement(By.Id("btnZzk"));
            //btnZzk.Click();
        }
        #endregion
    }
}
