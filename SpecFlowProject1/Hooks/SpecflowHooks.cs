using OpenQA.Selenium;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Pages;
using SpecFlowProject1.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class SpecflowHooks
    {
        private IWebDriver driver;
        private readonly AbrirLoginStepDefinitions loginStepDefinitions;
     
        public SpecflowHooks(AbrirLoginStepDefinitions loginStep)
        {
            driver = WebDriverFactory.GetDriver();
            loginStepDefinitions = new AbrirLoginStepDefinitions();

        }

        [BeforeScenario()] 
        public void BeforeScenario()
        {
                loginStepDefinitions.GivenQueEstejaNaPaginaPrincipal();
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                loginStepDefinitions.WhenPreencherOsDadosDeLoginDaPlataforma();
                loginStepDefinitions.ThenClicandoEmEntrarTereiFeitoOLogin();   
        }


        [AfterScenario]
        public void AfterScenario()
        {
            WebDriverFactory.CloseDriver();
        }

    }
}
