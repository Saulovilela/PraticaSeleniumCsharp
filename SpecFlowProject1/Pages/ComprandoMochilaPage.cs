using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.Elements;
using System.IO.Compression;

namespace SpecFlowProject1.Pages
{
    public class ComprandoMochilaPage
    {
        public void ClicarImagemMochila(IWebDriver driver)
        {
            driver.FindElement(By.XPath(ComprandoMochilaElements.ImageMochila)).Click();
        }
        public void ClicaMochila(IWebDriver driver)
        {
            driver.FindElement(By.XPath(ComprandoMochilaElements.BtnAddMochila)).Click();
        }
        public void ClickAddToCart(IWebDriver driver)
        {
            driver.FindElement(By.XPath(ComprandoMochilaElements.BtnAddToCart)).Click();
        }
        public void ClickCart(IWebDriver driver)
        {
            driver.FindElement(By.ClassName(ComprandoMochilaElements.BtnCart)).Click();
        }
        public void ClickCheckout(IWebDriver driver)
        {
            driver.FindElement(By.XPath(ComprandoMochilaElements.BtnCheckout)).Click();
        }

        public void PreencheDados(string firstname, string lastname, string zipcode, IWebDriver driver)
        {
            driver.FindElement(By.Id(ComprandoMochilaElements.FirstName)).SendKeys(firstname);
            driver.FindElement(By.Id(ComprandoMochilaElements.LastName)).SendKeys(lastname);
            driver.FindElement(By.Id(ComprandoMochilaElements.ZipCode)).SendKeys(zipcode);
            driver.FindElement(By.XPath(ComprandoMochilaElements.BtnContinue)).Click();
        }
        public void FinalizaCompra(IWebDriver driver)
        {
            driver.FindElement(By.XPath(ComprandoMochilaElements.BtnFinish)).Click();
        }
    }
}
