using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class AccountInfoPageObject : BasePageObject
    {
        private By EditButton = By.XPath("//*[@id=\"group - personal - title\"]/a[2]");
        private By NameField = By.XPath("//*[@id=\"updated - first - name\"]");
        private By DoneButton = By.XPath("//*[@id=\"group - personal - title\"]/a[1]");
        public AccountInfoPageObject(IWebDriver driver) : base(driver) { }

        public AccountInfoPageObject EditName()
        {
            driver.FindElement(EditButton).Click();
            Log.Info("Click Edit Button");

            driver.FindElement(NameField).SendKeys("pudge");
            Log.Info("Input new name");

            driver.FindElement(DoneButton).Click();
            Log.Info("Click done button");
            return new AccountInfoPageObject(driver);
        }
        public string NameAccount()
        {
            return driver.FindElement(DoneButton).Text;
        }
    }
}
