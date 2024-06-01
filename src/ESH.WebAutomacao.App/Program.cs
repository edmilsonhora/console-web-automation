using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace ESH.WebAutomacao.App
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            IWebDriver driver = new FirefoxDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;           

            driver.Navigate().GoToUrl("https://www.4devs.com.br/gerador_de_pessoas");
            driver.Manage().Window.Size = new System.Drawing.Size(950, 792);
            js.ExecuteScript("window.scrollTo(0,108)");
            js.ExecuteScript("window.scrollTo(0,487.20001220703125)");
            js.ExecuteScript("window.scrollTo(0,825.5999755859375)");

            driver.FindElement(By.Id("txt_qtde")).Click();
            driver.FindElement(By.Id("txt_qtde")).Clear();
            driver.FindElement(By.Id("txt_qtde")).Click();
           
            driver.FindElement(By.Id("txt_qtde")).SendKeys("30");
            
            js.ExecuteScript("window.scrollTo(0,1043.199951171875)");
           
            {
                var element = driver.FindElement(By.Id("bt_gerar_pessoa"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.Id("bt_gerar_pessoa")).Click();
           
            System.Threading.Thread.Sleep(3000);
            js.ExecuteScript("window.scrollTo(0,1378.4000244140625)");
            driver.FindElement(By.CssSelector(".button--download")).Click();
        }
    }
}
