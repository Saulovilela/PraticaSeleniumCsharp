using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Pages;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AbrirLoginStepDefinitions
    {
        private readonly IWebDriver driver;

        public AbrirLoginStepDefinitions()
        {
            driver = WebDriverFactory.GetDriver();
        }


        [Given(@"que esteja na pagina principal")]
        public void GivenQueEstejaNaPaginaPrincipal()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
        }

        [When(@"preencher os dados de login da plataforma")]
        public void WhenPreencherOsDadosDeLoginDaPlataforma()
        {
            AbrirLoginPage loginPage = new AbrirLoginPage();
            loginPage.PreencherLogin("standard_user", "secret_sauce", driver);
        }

        [Then(@"clicando em entrar terei feito o login")]
        public void ThenClicandoEmEntrarTereiFeitoOLogin()
        {
            AbrirLoginPage loginPage = new AbrirLoginPage();
            loginPage.ClicarLogin(driver);
        }
    }
}
