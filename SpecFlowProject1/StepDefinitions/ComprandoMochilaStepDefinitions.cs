using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Pages;
using OpenQA.Selenium;
using SpecFlowProject1.Drivers;
using OpenQA.Selenium.Interactions;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ComprandoMochilaStepDefinitions
    {
        private readonly IWebDriver driver;

        public ComprandoMochilaStepDefinitions()
        {
            driver = WebDriverFactory.GetDriver();
        }

        [Given(@"que eu clique na mochila")]
        public void GivenQueEuCliqueNaMochila()
        {
            Thread.Sleep(1000);
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClicarImagemMochila(driver);
        }

        [When(@"clicar em add ao carrinho")]
        public void WhenClicarEmAddAoCarrinho()
        {
            Thread.Sleep(1000);
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClickAddToCart(driver);
        }

        [When(@"clicar no carrinho")]
        public void WhenClicarNoCarrinho()
        {
            Thread.Sleep(1000);
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClickCart(driver);
        }

        [When(@"clicar em checkout")]
        public void WhenClicarEmCheckout()
        {
            Thread.Sleep(1000);
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.ClickCheckout(driver);
        }

        [When(@"coloco os dados de nome sobrenome e cep")]
        public void WhenColocoOsDadosDeNomeSobrenomeECep()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
            comprandoMochilaPage.PreencheDados("teste","teste", "0001", driver);
        }

        [When(@"clico em finalizar")]
        public void WhenClicoEmFinalizar()
        {
            ComprandoMochilaPage comprandoMochilaPage = new ComprandoMochilaPage();
    
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Perform();
            System.Threading.Thread.Sleep(2000);
            comprandoMochilaPage.FinalizaCompra(driver);
        }

        [Then(@"terei feito com sucesso a compra")]
        public void ThenTereiFeitoComSucessoACompra()
        {
            
        }

    }
}
