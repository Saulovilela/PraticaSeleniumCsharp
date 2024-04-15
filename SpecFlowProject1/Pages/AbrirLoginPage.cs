using OpenQA.Selenium;
using SpecFlowProject1.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class AbrirLoginPage
    {
        public void PreencherLogin(string username, string password, IWebDriver driver)
        {
            driver.FindElement(By.Id(AbrirLoginElements.Username)).SendKeys(username);
            driver.FindElement(By.Id(AbrirLoginElements.Password)).SendKeys(password);
        }
        public void ClicarLogin(IWebDriver driver)
        {
            driver.FindElement(By.Id(AbrirLoginElements.BtnLogin)).Click();
        }
    }
}
