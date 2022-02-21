using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObjects
{
    public class MainMenuPageObject : BasePageObject
    {
        private By logInBtn = By.XPath("//div[@class='menu-section']//a[@id='header-signin-link']");
        private By myPortfolios = By.XPath("//a[@href='/portfolios']");

        private By EditButton = By.XPath("//*[@id=\"group - personal - title\"]/a[2]");
        private By NameField = By.XPath("//*[@id=\"updated - first - name\"]");
        private By DoneButton = By.XPath("//*[@id=\"group - personal - title\"]/a[1]");

        private By AccountPreferences = By.XPath("//*[@id=\"menu - sidebar\"]/ul/li[4]/a");
        private By SelectLanguage = By.XPath("//*[@id=\"language - dropdown\"]");
        private By RussianLanguage = By.XPath("//*[@id=\"language - dropdown\"]/option[67]");
        private By MoreBut = By.XPath("//*[@id=\"eyebrow\"]/li[9]/a");
        
        public MainMenuPageObject(IWebDriver driver) : base(driver) { }
        public AuthorizationPageObject SignUp()
        {
            driver.FindElement(logInBtn).Click();
            Log.Info("Start Authorization");
            return new AuthorizationPageObject(driver);
        }
        public MyPortfolioPageObject SwitchToMyPortfolios()
        {
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(myPortfolios).Click();
            Log.Info("Switch To My Portfolios");
            return new MyPortfolioPageObject(driver);
        }
        public ProductandServicesPageObject ClickMore()
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(MoreBut).Click();
            Log.Info("Click More.. Button");
            Log.Info(driver.Url.ToString());
            return new ProductandServicesPageObject(driver);
        }
    }
}
