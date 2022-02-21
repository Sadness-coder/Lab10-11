using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class ProductandServicesPageObject : BasePageObject
    {
        private By MoveToAccount = By.XPath("//*[@id=\"Col1 - 0 - Everything - Proxy\"]/div/div[1]/dl[1]/div[1]/dd/a");
        
        public ProductandServicesPageObject(IWebDriver driver) : base(driver) { }
        
        public AccountInfoPageObject AccButton()
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(MoveToAccount).Click();
            Log.Info("Click button Accounts");
            return new AccountInfoPageObject(driver);
        }

    }
}
